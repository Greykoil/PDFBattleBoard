using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFBattleBoard.Model
{
    internal enum Frequency
    {
        Sectional,
        Daily,
        PerEvent
    }

    internal class ChargedAbility
    {
        public string Name { get; set; }
        public int Charges { get; set; }
        public Frequency Frequent { get; set; }
    }
}
