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
                        Values = new List<AcValue>()
                        {
                            new AcValue { Name = "Physical", Value = 10 },
                            new AcValue { Name = "Magic", Value = 11 },
                            new AcValue { Name = "Power", Value = 12 },
                            new AcValue { Name = "A Dex", Value = 13 },
                            new AcValue { Name = "U Dex", Value = 14 },
                            new AcValue { Name = "Undead", Value = 15 },
                            new AcValue { Name = "Evil", Value = 16 },
                            new AcValue { Name = "Psy", Value = 17 }
                        }
                    }
                },
                PoolAbilites = new List<PoolAbility>()
                {
                    new PoolAbility()
                    {
                        Name = "Life",
                        Total = 500,
                        Talisman = 0,
                        Self = 0,
                        MedCharges = 2
                    },
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
