using BattleBoardModel.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BattleBoardViewModel
{
    public class PoolAbilityViewModel : BindableObject
    {

        public ICommand AddNewPoolAbility { get; }
        public ICommand DeletePool { get; }

        public PoolAbility NewPoolAbility
        { 
            get; 
            set; 
        }

        private List<PoolAbility> _poolAbilities;

        public ObservableCollection<PoolAbility> PoolAbilities { get; } = new ObservableCollection<PoolAbility>();

        public PoolAbilityViewModel(IEnumerable<PoolAbility> poolAbilities)
        {
            _poolAbilities = poolAbilities.ToList();

            foreach (var item in poolAbilities)
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
        }

        private void OnAddNewPoolAbility()
        {
            _poolAbilities.Add(NewPoolAbility);
            PoolAbilities.Add(NewPoolAbility);

            NewPoolAbility = new PoolAbility()
            {
                Name = "foo",
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

    }
}
