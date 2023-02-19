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
        Sectional = 0,
        Daily = 1,
        PerEvent = 2,
        OnceEver = 3
    }

    public class ChargedAbility
    {
        public string Name { get; set; }
        public int Charges { get; set; }
        public Frequency Frequent { get; set; }
        public Source Source { get; set; }
    }
}
