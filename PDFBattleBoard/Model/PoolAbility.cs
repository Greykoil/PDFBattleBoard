namespace PDFBattleBoard.Model
{
    internal class PoolAbility
    {
        public string Name { get; set; }
        public int Total { get; set; }
        public int Out { get; set; }
        public int Self { get; set; }
        public int Talisman { get; set; }
        public int MedCharges { get; set; }
        public bool HasOut { get; set; }
    }
}
