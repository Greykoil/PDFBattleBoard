namespace PDFBattleBoard.Model
{
    struct SpellSlots
    {
        public int Level { get; set; }
        public int Total { get; set; }
        public int Out { get; set; }

    }
    internal class MagicDetails
    {
        public List<SpellSlots> SpellSlots { get; set; }
        public int Mnemonics { get; set; }
        public int Regain { get; set; }
    }
}
