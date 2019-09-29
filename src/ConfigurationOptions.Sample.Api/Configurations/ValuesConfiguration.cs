using System;
using System.ComponentModel.DataAnnotations;

namespace ConfigurationOptions.Sample.Api.Configurations
{
    public class ValuesConfiguration
    {
        public const string SECTION = "ValuesConfig";

        [Range(1,10)]
        public int ValuesCount { get; set; }

        [Required]
        public String ValuesPreset { get; set; }
    }
}
