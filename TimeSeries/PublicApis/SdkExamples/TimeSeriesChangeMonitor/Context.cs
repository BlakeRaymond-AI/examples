﻿using System;
using System.Collections.Generic;
using Aquarius.TimeSeries.Client.ServiceModels.Publish;
using NodaTime;

namespace TimeSeriesChangeMonitor
{
    public class Context
    {
        public string Server { get; set; } = "localhost";
        public string Username { get; set; } = "admin";
        public string Password { get; set; } = "admin";
        public string LocationIdentifier { get; set; }
        public string Parameter { get; set; }
        public bool? Publish { get; set; }
        public string ComputationIdentifier { get; set; }
        public string ComputationPeriodIdentifier { get; set; }
        public ChangeEventType? ChangeEventType { get; set; }
        public List<ExtendedAttributeFilter> ExtendedFilters { get; set; } = new List<ExtendedAttributeFilter>();
        public List<string> TimeSeries { get; set; } = new List<string>();
        public Instant ChangesSinceTime { get; set; } = Instant.FromDateTimeUtc(DateTime.UtcNow);
        public Duration PollInterval { get; set; } = Duration.FromSeconds(10);
        public int MaximumChangeCount { get; set; }
    }
}
