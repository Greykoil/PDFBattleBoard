using BattleBoardModel.Model;

namespace BattleBoardViewModel
{
    public class PlayerDetailsViewModel : BindableObject
    {

        private CharacterDetails Player;

        public PlayerDetailsViewModel(CharacterDetails details)
        {
            Player = details;
        }

        public string CharacterName
        {
            get => Player.Name;
            set
            {
                Player.Name = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(CharacterDetailsString));
            }
        }

        public string CharacterClass
        {
            get => Player.PlayerClass.ToString();
            set
            {
                Player.PlayerClass = Enum.Parse<PcClass>(value);
                OnPropertyChanged();
                OnPropertyChanged(nameof(CharacterDetailsString));
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
                OnPropertyChanged(nameof(CharacterDetailsString));
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
                OnPropertyChanged(nameof(CharacterDetailsString));
            }
        }

        public int CharacterResChances
        {
            get => Player.ResChances;
            set
            {
                Player.ResChances = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(CharacterDetailsString));
            }
        }

        public string CharacterDetailsString
        {
            get => $"Character {CharacterName} - Class {CharacterClass} " +
                   $"- Race {CharacterRace} - Points {CharacterPoints} - Res {CharacterResChances}";
            set
            {
                OnPropertyChanged();
            }
        }
    }
}