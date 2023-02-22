using BattleBoardModel;
using BattleBoardModel.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BattleBoardViewModel
{
    public class ArmourViewModel : BindableObject
    {
        private Armour _armour;

        public AcValue NewACValue { get; set; }

        public ArmourViewModel(ICharacterInterface characterInterface)
        {
            _armour = characterInterface.GetCharacter().Details.CharacterArmour;
            foreach (var item in _armour.Values)
            {
                ArmourValues.Add(item);
            }
            AddNewArmourValue = new Command(OnAddNewAc);

            DeleteACValue = new Command<AcValue>(OnDeleteAcValue);
            _characterInterface = characterInterface;
            NewACValue = new AcValue()
            {
                Name = "New AC",
                Value = 0
            };
        }

        public ICommand AddNewArmourValue { get; }

        public ICommand DeleteACValue { get; }

        public ObservableCollection<AcValue> ArmourValues { get; } = new ObservableCollection<AcValue>();
        public ICharacterInterface _characterInterface { get; }

        private void OnAddNewAc()
        {
            _armour.Values.Add(NewACValue);
            ArmourValues.Add(NewACValue);
            NewACValue = new AcValue()
            {
                Name = "New AC",
                Value = 0
            };
            OnPropertyChanged(nameof(NewACValue));
        }

        private void OnDeleteAcValue(AcValue acValue) 
        {
            _armour.Values.Remove(acValue);
            ArmourValues.Remove(acValue);
        }

        public void OnAppearing()
        {
            _armour = _characterInterface.GetCharacter().Details.CharacterArmour;

            ArmourValues.Clear();

            foreach (var item in _armour.Values)
            {
                ArmourValues.Add(item);
            }
        }
    }
}
