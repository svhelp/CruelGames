using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Settings.ConfigSection
{
    public class BattleConfigElement : ConfigurationElement
    {
        [ConfigurationProperty("drawResult", DefaultValue = "1", IsRequired = true)]
        [IntegerValidator(ExcludeRange = false, MinValue = 0)]
        public int DrawResult
        {
            get { return (int)this["drawResult"]; }
            set { this["drawResult"] = value; }
        }

        [ConfigurationProperty("loseResult", DefaultValue = "-1", IsRequired = true)]
        [IntegerValidator(ExcludeRange = false, MaxValue = -1)]
        public int LoseResult
        {
            get { return (int)this["loseResult"]; }
            set { this["loseResult"] = value; }
        }

        [ConfigurationProperty("winResult", DefaultValue = "2", IsRequired = true)]
        [IntegerValidator(ExcludeRange = false, MinValue = 1)]
        public int WinResult
        {
            get { return (int)this["winResult"]; }
            set { this["winResult"] = value; }
        }
    }
}
