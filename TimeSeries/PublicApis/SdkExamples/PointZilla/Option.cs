﻿using System;

namespace PointZilla
{
    public class Option
    {
        public string Key { get; set; }
        public string Description { get; set; }
        public Action<string> Setter { get; set; }
        public Func<string> Getter { get; set; }

        public string UsageText()
        {
            var defaultValue = Getter();

            if (!string.IsNullOrEmpty(defaultValue))
                defaultValue = $" [default: {defaultValue}]";

            return $"{Key,-22} {Description}{defaultValue}";
        }
    }
}
