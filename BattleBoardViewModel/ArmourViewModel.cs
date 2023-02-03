using BattleBoardModel.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BattleBoardViewModel
{
    public class ArmourViewModel : BindableObject
    {
        private Armour _armour;

        private string _newACName = "New Value";

        public string NewACName
        {
            get => _newACName;
            set
            {
                _newACName = value;
                OnPropertyChanged();
            }
        }

        private int _newACValue = 0;

        public int NewACValue
        {
            get => _newACValue;
            set
            {
                _newACValue = value;
                OnPropertyChanged();
            }
        }

        public ArmourViewModel(Armour armour)
        {
            _armour = armour;
            foreach (var item in _armour.Values)
            {
                ArmourValues.Add(item);
            }
            AddNewArmourValue = new Command(OnAddNewAc);

            DeleteACValue = new Command<AcValue>(OnDeleteAcValue);
        }

        public ICommand AddNewArmourValue { get; }

        public ICommand DeleteACValue { get; }

        public ObservableCollection<AcValue> ArmourValues { get; } = new ObservableCollection<AcValue>();
        
        private void OnAddNewAc()
        {
            var newValue = new AcValue() { Name = NewACName, Value = NewACValue };
            _armour.Values.Add(newValue);
            ArmourValues.Add(newValue);
            NewACName = "New Value";
            NewACValue = 0;
        }

        private void OnDeleteAcValue(AcValue acValue) 
        {
            _armour.Values.Remove(acValue);
            ArmourValues.Remove(acValue);
        }
    }
}
