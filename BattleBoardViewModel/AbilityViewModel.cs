using BattleBoardModel.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BattleBoardViewModel
{
    public class AbilityViewModel : BindableObject
    {
        private List<ChargedAbility> _abilities;

        public ObservableCollection<ChargedAbility> Abilites { get; } = new ObservableCollection<ChargedAbility>();

        public AbilityViewModel(IEnumerable<ChargedAbility> abilities) 
        {
            _abilities = abilities.ToList();

            foreach (var item in abilities)
            {
                Abilites.Add(item);
            }
            AddNewAbility = new Command(OnAddNewAbility);
            DeleteAbility = new Command<ChargedAbility>(OnDeleteAbility);
        }

        public ICommand AddNewAbility { get;  }
        public ICommand DeleteAbility { get;  }

        private string newAbilityName = "New Ability";
        public string NewAbilityName
        {
            get { return newAbilityName; }
            set {
                newAbilityName = value;
                OnPropertyChanged();
            }
        }

        private int newAbilityCharges = 1;
        public int NewAbilityCharges
        {
            get { return newAbilityCharges; }
            set
            {
                newAbilityCharges = value;
                OnPropertyChanged();
            }
        }

        public List<string> NewAbilityFrequencyOptions
        {
            get
            {
                return Enum.GetNames(typeof(Frequency)).ToList();
            }
        }

        private string newAbiltyFrequency;

        public string NewAbilityFrequency
        {
            get => newAbiltyFrequency;
            set
            {
                newAbiltyFrequency = value;
                OnPropertyChanged();
            }
        }

        public List<string> NewAbilitySourceOptions
        {
            get
            {
                return Enum.GetNames(typeof(Source)).ToList();
            }
        }

        private string newAbilitySource;
        
        public string NewAbilitySource
        {
            get => newAbilitySource;
            set
            {
                newAbilitySource = value;
                OnPropertyChanged();
            }
        }

        private void OnAddNewAbility()
        {
            var newAbility = new ChargedAbility()
            {
                Name = NewAbilityName,
                Charges = NewAbilityCharges,
                Source = Enum.Parse<Source>(NewAbilitySource),
                Frequent = Enum.Parse<Frequency>(newAbiltyFrequency)
            };

            _abilities.Add(newAbility);
            Abilites.Add(newAbility);

            NewAbilityName = "New ability name";
            NewAbilityCharges = 1;
            NewAbilitySource = Source.Ability.ToString();
            NewAbilityFrequency = Frequency.PerEvent.ToString();
        }

        private void OnDeleteAbility(ChargedAbility ability)
        {
            _abilities.Remove(ability);
            Abilites.Remove(ability);
        }

    }
}
