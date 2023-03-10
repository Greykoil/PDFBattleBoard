namespace BattleBoardModel.Model
{
    public class AcValue
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }

    public class Armour
    {
        public List<AcValue> Values { get; set; } = new List<AcValue>();
    }
}
