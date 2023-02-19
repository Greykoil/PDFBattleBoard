using BattleBoardModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleBoardModel
{
    public class CharacterInterface : ICharacterInterface
    {

        Character currentCharacter;

        public CharacterInterface() 
        {
            currentCharacter = Utils.CharacterBuilder.DemoCharacter();
        }

        public Character GetCharacter()
        {
            return currentCharacter;
        }

        public void UpdateCharacter(Character character)
        {
            currentCharacter = character;
        }
    }
}
