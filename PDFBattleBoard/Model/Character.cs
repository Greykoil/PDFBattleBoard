using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFBattleBoard.Model
{
    internal class Character
    {

        public CharacterDetails Details { get; set; }
        public List<ChargedAbility> ChargedAbilities { get; set; }
        public List<PoolAbility> PoolAbilites { get; set; }

    }
}
