using BattleBoardModel;
using BattleBoardModel.Model;
using System.Collections.ObjectModel;
using System.Reflection.Metadata;
using System.Windows.Input;

namespace BattleBoardViewModel
{
    public class AbilityViewModel : BindableObject
    {

        private ICharacterInterface _characterInterface;
        private List<ChargedAbility> _abilities;

        public ObservableCollection<ChargedAbility> Abilites { get; } = new ObservableCollection<ChargedAbility>();

        public AbilityViewModel(ICharacterInterface characterInterface) 
        {
            _characterInterface = characterInterface;

            _abilities = characterInterface.GetCharacter().ChargedAbilities;

            foreach (var item in _abilities)
            {
                Abilites.Add(item);
            }
            AddNewAbility = new Command(OnAddNewAbility);
            DeleteAbility = new Command<ChargedAbility>(OnDeleteAbility);
            NewAbility = new ChargedAbility()
            {
                Name = "New Ability",
                Charges = 0,
                Source = Source.Ability,
                Frequent = Frequency.Daily
            };
        }

        public ICommand AddNewAbility { get;  }
        public ICommand DeleteAbility { get;  }

        public ChargedAbility NewAbility { get; set; }

        private void OnAddNewAbility()
        {
            _abilities.Add(NewAbility);
            Abilites.Add(NewAbility);

            NewAbility = new ChargedAbility()
            {
                Name = "New Ability",
                Charges = 0,
                Source = Source.Ability,
                Frequent = Frequency.Daily
            };
            OnPropertyChanged(nameof(NewAbility));
        }

        public List<string> NewAbilityFrequencyOptions { get; } = Enum.GetNames(typeof(Frequency)).ToList();

        private void OnDeleteAbility(ChargedAbility ability)
        {
            _abilities.Remove(ability);
            Abilites.Remove(ability);
        }
        
        public List<string> NewAbilitySourceOptions { get; } = Enum.GetNames(typeof(Source)).ToList();

        public void OnAppearing()
        {
            _abilities = _characterInterface.GetCharacter().ChargedAbilities;

            Abilites.Clear();

            foreach (var item in _abilities)
            {
                Abilites.Add(item);
            }
        }
    }
}
