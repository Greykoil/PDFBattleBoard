using BattleBoardModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleBoardModel
{
    public interface ICharacterInterface
    {
        Character GetCharacter();

        void UpdateCharacter(Character character);

    }
}
