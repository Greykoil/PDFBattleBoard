using PDFBattleBoard.Model;

namespace PDFBattleBoard.Utils
{
    internal class CharacterBuilder
    {

        public static Character BuildCharacter()
        {

            return DemoCharacter();

        }

        public static Character DemoCharacter()
        {
            return new Character()
            {
                Details = new CharacterDetails()
                {
                    Name = "Demo Character Name",
                    Points = 1000,
                    ResChances = 2,
                    CharacterRace = PcRace.Human,
                    PlayerClass = PcClass.Scout,
                    CharacterArmour = new Armour()
                    {
                        Physical = 10,
                        PureMagic = 11,
                        PurePower = 12,
                        ArmouredDex = 13,
                        UnarmouredDex = 14,
                        Undead = 15,
                        Evil = 16,
                    }
                },
                PoolAbilites = new List<PoolAbility>()
                {
                    new PoolAbility() {
                        Name = "Power",
                        Total = 200,
                        Talisman = 50,
                        Self = 150,
                        MedCharges = 2
                    },
                    new PoolAbility()
                    {
                        Name = "Kai",
                        Total = 200,
                        Talisman = 50,
                        Self = 150,
                        MedCharges = 2
                    },
                    new PoolAbility()
                    {
                        Name = "LifePool",
                        Total = 500,
                        Talisman = 0,
                        Self = 0,
                        MedCharges = 2
                    }
                },
                ChargedAbilities = new List<ChargedAbility>()
                {
                    new ChargedAbility()
                    {
                        Name = "Resist Knockback",
                        Charges = 5,
                        Frequent = Frequency.Daily
                    },
                     new ChargedAbility()       {
                        Name = "Resist Disarm",
                        Charges = 4,
                        Frequent = Frequency.Sectional
                    },
                    new ChargedAbility()  {
                        Name = "Resist Dismember",
                        Charges = 3,
                        Frequent = Frequency.PerEvent
                    }
                }
            };
        }
    }
}
