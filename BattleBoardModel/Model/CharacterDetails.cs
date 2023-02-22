namespace BattleBoardModel.Model
{
    public enum PcClass
    {
        Warrior,
        Wizard,
        Scout,
        Priest
    }

    public enum PcRace
    {
        Human,
        HalfOrc,
        Elf
    }

    public class CharacterDetails
    {
        public string Name { get; set; }
        public PcClass PlayerClass { get; set; }
        public PcRace CharacterRace { get; set; }
        public int Points { get; set; }
        public int ResChances { get; set; }
        public Armour CharacterArmour { get; set; }
    }
}
