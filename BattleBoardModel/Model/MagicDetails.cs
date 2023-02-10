namespace BattleBoardModel.Model
{
    public class SpellSlots
    {
        public int Level { get; set; }
        public int Total { get; set; }
        public int Out { get; set; }
    }

    public class MagicDetails
    {
        public List<SpellSlots> SpellSlots { get; set; }
        public int Mnemonics { get; set; }
        public int Regain { get; set; }
    }
}
