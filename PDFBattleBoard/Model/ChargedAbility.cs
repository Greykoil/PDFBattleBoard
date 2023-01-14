namespace PDFBattleBoard.Model
{
    internal enum Source
    {
        Ability,
        Item,
        Store
    }

    internal enum Frequency
    {
        Sectional,
        Daily,
        PerEvent,
        OnceEver
    }

    internal class ChargedAbility
    {
        public string Name { get; set; }
        public int Charges { get; set; }
        public Frequency Frequent { get; set; }
        public Source Source { get; set; }
    }
}
