using BattleBoardModel;
using BattleBoardModel.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BattleBoardViewModel
{
    public class MagicViewModel : BindableObject
    {
        public SpellSlots NewMagicLevel { get; set; }


        private MagicDetails _magic;

        public MagicViewModel(ICharacterInterface characterInterface)
        {
            _magic = characterInterface.GetCharacter().CharacterMagic;
            foreach (var item in _magic.SpellSlots)
            {
                MagicSlots.Add(item);
            }

            AddNewMagicSlot = new Command(OnAddNewMagicSlot);

            DeleteMagicSlot = new Command<SpellSlots>(OnDeleteMagicSlot);

            NewMagicLevel = new SpellSlots()
            {
                Level = 0,
                Total = 0,
                Out = 0,
            };
        }

        public ICommand AddNewMagicSlot { get; }
        public ICommand DeleteMagicSlot { get; }

        public ObservableCollection<SpellSlots> MagicSlots { get; } = new ObservableCollection<SpellSlots>();

        public MagicDetails MagicDetails
        {
            get { return _magic; }
            set { 
                _magic = value;
                OnPropertyChanged();
            }
        }

        private void OnAddNewMagicSlot()
        {
            _magic.SpellSlots.Add(NewMagicLevel);
            MagicSlots.Add(NewMagicLevel);
            NewMagicLevel = new SpellSlots()
            {
                Level = 0,
                Total = 0,
                Out = 0,
            };

            MagicSlots.OrderByDescending(x => x.Level);
            OnPropertyChanged(nameof(NewMagicLevel));
        }

        private void OnDeleteMagicSlot(SpellSlots slot)
        {
            _magic.SpellSlots.Remove(slot);
            MagicSlots.Remove(slot);
        }
    }
}
