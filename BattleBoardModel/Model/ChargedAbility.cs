namespace BattleBoardModel.Model
{
    public enum Source
    {
        Ability,
        Item,
        Store
    }

    public enum Frequency
    {
        Sectional,
        Daily,
        PerEvent,
        OnceEver
    }

    public class ChargedAbility
    {
        public string Name { get; set; }
        public int Charges { get; set; }
        public Frequency Frequent { get; set; }
        public Source Source { get; set; }
    }
}
