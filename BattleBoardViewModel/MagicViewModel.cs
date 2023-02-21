using BattleBoardModel;
using BattleBoardModel.Model;
using System.Collections.ObjectModel;
using System.Reflection.Metadata.Ecma335;

namespace BattleBoardViewModel
{
    public class MagicViewModel : BindableObject
    {

        public int MnemonicCharges
        {
            get { return _magic.Mnemonics; }
            set { _magic.Mnemonics = value; }
        }

        public int MnemonicRegain
        {
            get { return _magic.Regain; }
            set { _magic.Regain = value; }
        }

        public bool HasBattleMagic
        {
            get
            {
                return _magic.SpellSlots.Any();
            }
            set
            {
                if (value == false)
                {
                    _magic.SpellSlots.Clear();
                    UpdateCollection();
                    OnPropertyChanged(nameof(HasBattleMagic));
                    OnPropertyChanged(nameof(HasWizardyMagic));
                    OnPropertyChanged(nameof(HasSorceryMagic));
                }
                else
                {
                    for (int i = 1; i <= 5; ++i)
                    {
                        if (!_magic.SpellSlots.Any(x => x.Level == i))
                        {
                            _magic.SpellSlots.Add(new SpellSlots() { Level = i, Total = 0, Out = 0 });
                        }
                    }
                    UpdateCollection();
                    OnPropertyChanged(nameof(HasBattleMagic));
                }
            }
        }

        private void UpdateCollection()
        {
            MagicSlots.Clear();
            foreach (var item in _magic.SpellSlots)
            {
                MagicSlots.Add(item);
            }
        }

        public void OnAppearing()
        {
            _magic = _characterInterface.GetCharacter().CharacterMagic;
            MagicSlots.Clear();
            foreach (var item in _magic.SpellSlots)
            {
                MagicSlots.Add(item);
            }
            OnPropertyChanged(nameof(HasBattleMagic));
            OnPropertyChanged(nameof(HasWizardyMagic));
            OnPropertyChanged(nameof(HasSorceryMagic));
            OnPropertyChanged(nameof(MnemonicCharges));
            OnPropertyChanged(nameof(MnemonicRegain));
        }

        public bool HasWizardyMagic
        {
            get
            {
                return _magic.SpellSlots.Any(x => x.Level > 5);
            }
            set
            {
                if (value == false)
                {
                    _magic.SpellSlots.RemoveAll(x => x.Level > 5);
                    UpdateCollection();
                    OnPropertyChanged(nameof(HasWizardyMagic));
                    OnPropertyChanged(nameof(HasSorceryMagic));
                }
                else
                {
                    if (!HasBattleMagic)
                    {
                        HasBattleMagic = true;
                    }
                    for (int i = 6; i <= 8; ++i)
                    {
                        if (!_magic.SpellSlots.Any(x => x.Level == i))
                        {
                            _magic.SpellSlots.Add(new SpellSlots() { Level = i, Total = 0, Out = 0 });
                        }
                    }
                    UpdateCollection();
                    OnPropertyChanged(nameof(HasWizardyMagic));
                }
            }
        }

        public bool HasSorceryMagic
        {
            get
            {
                return _magic.SpellSlots.Any(x => x.Level > 8);
            }
            set
            {
                if (value == false)
                {
                    _magic.SpellSlots.RemoveAll(x => x.Level > 8);
                    UpdateCollection();
                    OnPropertyChanged(nameof(HasSorceryMagic));
                }
                else
                {
                    if (!HasWizardyMagic)
                    {
                        HasWizardyMagic = true;
                    }
                    for (int i = 9; i <= 10; ++i)
                    {
                        if (!_magic.SpellSlots.Any(x => x.Level == i))
                        {
                            _magic.SpellSlots.Add(new SpellSlots() { Level = i, Total = 0, Out = 0 });
                        }
                    }
                    UpdateCollection();
                    OnPropertyChanged(nameof(HasSorceryMagic));
                }
            }
        }

        private ICharacterInterface _characterInterface;
        private MagicDetails _magic;

        public MagicViewModel(ICharacterInterface characterInterface)
        {
            _characterInterface = characterInterface;
            _magic = characterInterface.GetCharacter().CharacterMagic;
            foreach (var item in _magic.SpellSlots)
            {
                MagicSlots.Add(item);
            }
        }

        public ObservableCollection<SpellSlots> MagicSlots { get; } = new ObservableCollection<SpellSlots>();
    }
}
