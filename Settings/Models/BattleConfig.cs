using System;
using System.Collections.Generic;
using System.Text;

namespace Settings.Models
{
    /// <summary>
    /// Настройки наград по результатам раунда.
    /// </summary>
    public sealed class BattleConfig
    {
        public int DrawResult { get; set; }
        public int LoseResult { get; set; }
        public int WinResult { get; set; }
    }
}
