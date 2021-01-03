using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Settings.ConfigSection
{
    public class GameConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("initialPlayerConfig")]
        public InitialPlayerConfigElement InitialPlayer
        {
            get { return (InitialPlayerConfigElement)this["initialPlayerConfig"]; }
            set { this["initialPlayerConfig"] = value; }
        }

        [ConfigurationProperty("battleConfig")]
        public BattleConfigElement Battle
        {
            get { return (BattleConfigElement)this["battleConfig"]; }
            set { this["battleConfig"] = value; }
        }

        [ConfigurationProperty("privateDiscussionTime", DefaultValue = "30", IsRequired = true)]
        [IntegerValidator(ExcludeRange = false, MinValue = 0)]
        public int PrivateDiscussionTime
        {
            get { return (int)this["privateDiscussionTime"]; }
            set { this["privateDiscussionTime"] = value; }
        }

        [ConfigurationProperty("publicDiscussionTime", DefaultValue = "90", IsRequired = true)]
        [IntegerValidator(ExcludeRange = false, MinValue = 0)]
        public int PublicDiscussionTime
        {
            get { return (int)this["publicDiscussionTime"]; }
            set { this["publicDiscussionTime"] = value; }
        }

        [ConfigurationProperty("winPointsThreshold", DefaultValue = "9", IsRequired = true)]
        [IntegerValidator(ExcludeRange = false, MinValue = 1)]
        public int WinPointsThreshold
        {
            get { return (int)this["winPointsThreshold"]; }
            set { this["winPointsThreshold"] = value; }
        }

        [ConfigurationProperty("losePointsThreshold", DefaultValue = "0", IsRequired = true)]
        public int LosePointsThreshold
        {
            get { return (int)this["losePointsThreshold"]; }
            set { this["losePointsThreshold"] = value; }
        }
    }
}
