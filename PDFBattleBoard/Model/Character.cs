namespace PDFBattleBoard.Model
{
    internal class Character
    {

        public CharacterDetails Details { get; set; }
        public List<ChargedAbility> ChargedAbilities { get; set; }
        public List<PoolAbility> PoolAbilites { get; set; }
        public MagicDetails CharacterMagic { get; set; }
    }
}
