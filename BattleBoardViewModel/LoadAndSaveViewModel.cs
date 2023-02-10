using BattleBoardModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BattleBoardViewModel
{
    public class LoadAndSaveViewModel : BindableObject
    {
        private ICharacterInterface _character;

        public ICommand LoadCharacter { get; set; }
        public ICommand SaveCharacter { get; set; }

        public LoadAndSaveViewModel(ICharacterInterface character)
        {
            _character = character;
            LoadCharacter = new Command(OnLoadCharacter);
            SaveCharacter = new Command(OnSaveCharacter);
        }

        private void OnLoadCharacter()
        {

        }

        private void OnSaveCharacter()
        {

        }
    }
}
