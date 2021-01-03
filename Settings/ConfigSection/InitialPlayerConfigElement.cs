using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Settings.ConfigSection
{
    public class InitialPlayerConfigElement : ConfigurationElement
    {
        [ConfigurationProperty("initialPoints", DefaultValue = "3", IsRequired = true)]
        [IntegerValidator(ExcludeRange = false, MinValue = 0)]
        public int InitialPoints
        {
            get { return (int)this["initialPoints"]; }
            set { this["initialPoints"] = value; }
        }
    }
}
