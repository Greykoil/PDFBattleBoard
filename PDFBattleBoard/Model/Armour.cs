namespace PDFBattleBoard.Model
{
    struct AcValue
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }
    internal class Armour
    {
        public List<AcValue> Values { get; set; } = new List<AcValue>();
    }
}
