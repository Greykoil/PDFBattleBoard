using BattleBoardModel;
using BattleBoardModel.Model;

namespace BattleBoardViewModel
{
    public class PlayerDetailsViewModel : BindableObject
    {

        private CharacterDetails Player;

        public PlayerDetailsViewModel(ICharacterInterface characterInterface)
        {
            Player = characterInterface.GetCharacter().Details;
        }

        public string CharacterName
        {
            get => Player.Name;
            set
            {
                Player.Name = value;
                OnPropertyChanged();
            }
        }

        public string CharacterClass
        {
            get => Player.PlayerClass.ToString();
            set
            {
                Player.PlayerClass = Enum.Parse<PcClass>(value);
                OnPropertyChanged();
            }
        }

        public IList<string> ClassOptions {
            get
            {
                return Enum.GetNames(typeof(PcClass)).ToList();
            }
        }

        public string CharacterRace
        {
            get => Player.CharacterRace.ToString();
            set
            {
                Player.CharacterRace = Enum.Parse<PcRace>(value);
                OnPropertyChanged();
            }
        }

        public IList<string> RaceOptions
        {
            get
            {
                return Enum.GetNames(typeof(PcRace)).ToList();
            }
        }

        public int CharacterPoints
        {
            get => Player.Points;
            set
            {
                Player.Points = value;
                OnPropertyChanged();
            }
        }

        public int CharacterResChances
        {
            get => Player.ResChances;
            set
            {
                Player.ResChances = value;
                OnPropertyChanged();
            }
        }
    }
}