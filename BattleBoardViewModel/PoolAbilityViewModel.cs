using BattleBoardModel;
using BattleBoardModel.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BattleBoardViewModel
{
    public class PoolAbilityViewModel : BindableObject
    {

        public ICommand AddNewPoolAbility { get; }
        public ICommand DeletePool { get; }

        public PoolAbility NewPoolAbility { get; set; }

        private List<PoolAbility> _poolAbilities;

        public ObservableCollection<PoolAbility> PoolAbilities { get; } = new ObservableCollection<PoolAbility>();
      
        public ICharacterInterface _characterInterface { get; }

        public PoolAbilityViewModel(ICharacterInterface characterInterface)
        {
            _poolAbilities = characterInterface.GetCharacter().PoolAbilites;

            foreach (var item in _poolAbilities)
            {
                PoolAbilities.Add(item);
            }

            NewPoolAbility = new PoolAbility()
            {
                Name = "foo",
                Total = 1,
                Out = 0,
                Self = 0,
                Talisman = 0,
                HasOut = false
            };

            AddNewPoolAbility = new Command(OnAddNewPoolAbility);
            DeletePool = new Command<PoolAbility>(OnDeletePoolAbility);
            _characterInterface = characterInterface;
        }

        private void OnAddNewPoolAbility()
        {
            _poolAbilities.Add(NewPoolAbility);
            PoolAbilities.Add(NewPoolAbility);

            NewPoolAbility = new PoolAbility()
            {
                Name = "New Pool",
                Total = 1,
                Out = 0,
                Self = 0,
                Talisman = 0,
                HasOut = false
            };
            OnPropertyChanged(nameof(NewPoolAbility));
        }

        private void OnDeletePoolAbility(PoolAbility ability)
        {
            _poolAbilities.Remove(ability);
            PoolAbilities.Remove(ability);
        }

        public void OnAppearing()
        {
            _poolAbilities = _characterInterface.GetCharacter().PoolAbilites;

            PoolAbilities.Clear();

            foreach (var item in _poolAbilities)
            {
                PoolAbilities.Add(item);
            }
        }
    }
}
