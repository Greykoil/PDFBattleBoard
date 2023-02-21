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
        public List<SpellSlots> SpellSlots { get; set; } = new List<SpellSlots>();
        public int Mnemonics { get; set; }
        public int Regain { get; set; }

        public bool HasBattleMagic { get; set; }
        public bool HasWizardryMagic { get; set; }
        public bool HasSorceryMagic { get; set; }
    }
}
