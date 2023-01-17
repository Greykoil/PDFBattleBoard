using PDFBattleBoard.Model;

namespace PDFBattleBoard.Utils
{
    internal class CharacterBuilder
    {

        public static Character BuildCharacter()
        {
            return Khandis();
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
                        MedCharges = 2,
                        HasOut = false
                    },
                    new PoolAbility() {
                        Name = "Power",
                        Total = 200,
                        Talisman = 50,
                        Self = 150,
                        MedCharges = 2,
                        HasOut = true,
                        Out = 75
                    },
                    new PoolAbility()
                    {
                        Name = "Kai",
                        Total = 200,
                        Talisman = 50,
                        Self = 150,
                        MedCharges = 2,
                        HasOut = false
                    }
                },
                ChargedAbilities = new List<ChargedAbility>()
                {
                    new ChargedAbility()
                    {
                        Name = "Resist Knockback",
                        Charges = 5,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Resist Dismember",
                        Charges = 2,
                        Frequent = Frequency.Sectional,
                        Source = Source.Ability
                    },
                     new ChargedAbility()       {
                        Name = "Resist Disarm",
                        Charges = 4,
                        Frequent = Frequency.Sectional,
                        Source = Source.Ability
                    },
                    new ChargedAbility()  {
                        Name = "Resist Bonebrake",
                        Charges = 3,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Ability
                    },
                    new ChargedAbility() {
                        Name = "Weakness Store",
                        Charges = 5,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility() {
                        Name = "Slow Store",
                        Charges = 5,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility() {
                        Name = "Cause Mortal Store",
                        Charges = 5,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility()
                    {
                        Name = "Good Spirit",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Heal",
                        Charges = 1,
                        Frequent = Frequency.OnceEver,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Banish Bastard",
                        Charges = 5,
                        Frequent = Frequency.OnceEver,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Control Fish",
                        Charges = 5,
                        Frequent = Frequency.OnceEver,
                        Source = Source.Item
                    }
                },
                CharacterMagic = new  MagicDetails()
                {
                    SpellSlots = new List<SpellSlots>()
                    {
                        new SpellSlots() {Level = 1, Total = 100, Out = 1},
                        new SpellSlots() {Level = 2, Total = 10, Out = 2},
                        new SpellSlots() {Level = 3, Total = 11, Out = 3},
                        new SpellSlots() {Level = 4, Total = 12, Out = 4},
                        new SpellSlots() {Level = 5, Total = 13, Out = 5},
                        new SpellSlots() {Level = 6, Total = 14, Out = 6},
                        new SpellSlots() {Level = 7, Total = 15, Out = 7},
                        new SpellSlots() {Level = 8, Total = 16, Out = 8},
                        new SpellSlots() {Level = 9, Total = 17, Out = 9},
                        new SpellSlots() {Level = 10, Total = 18, Out = 10},
                    },
                    Mnemonics = 1,
                    Regain = 150
                }
            };
        }

        public static Character Igor()
        {
            return new Character()
            {
                Details = new CharacterDetails()
                {
                    Name = "Igor",
                    Points = 550,
                    ResChances = 2,
                    PlayerClass = PcClass.Priest,
                    CharacterRace = PcRace.Human,
                    CharacterArmour = new Armour()
                    {
                        Values = new List<AcValue>()
                        {
                            new AcValue() { Name = "Physical", Value = 0},
                            new AcValue() { Name = "Magic", Value = 0},
                            new AcValue() { Name = "Power", Value = 0}
                        }
                    }
                },
                PoolAbilites = new List<PoolAbility>()
                {
                    new PoolAbility()
                    {
                        Name = "Life",
                        Total = 150,
                        Talisman = 0,
                        Self = 150,
                        MedCharges = 0
                    },
                    new PoolAbility()
                    {
                        Name = "Power",
                        Total = 250,
                        Talisman = 25,
                        Self = 225,
                        MedCharges = 2
                    }
                },
                ChargedAbilities = new List<ChargedAbility>()
                {
                    new ChargedAbility() { Name = "Repulsion", Charges = 1, Frequent = Frequency.Daily, Source = Source.Item},
                    new ChargedAbility() { Name = "Resist Mist Effect", Charges = 1, Frequent = Frequency.Daily, Source = Source.Ability},
                    new ChargedAbility() { Name = "Mystics Heal", Charges = 1, Frequent = Frequency.Daily, Source = Source.Ability},
                    new ChargedAbility() { Name = "Kings Resist", Charges = 1, Frequent = Frequency.Daily, Source = Source.Ability},
                    new ChargedAbility() { Name = "Mass Heal Scroll", Charges = 2, Frequent = Frequency.PerEvent, Source = Source.Item},
                },
                CharacterMagic = null,
            };
        }

        public static Character Albert()
        {
            return new Character()
            {
                Details = new CharacterDetails()
                {
                    Name = "Albert",
                    Points = 778,
                    ResChances = 3,
                    PlayerClass = PcClass.Priest,
                    CharacterRace = PcRace.Human,
                    CharacterArmour = new Armour()
                    {
                        Values = new List<AcValue>()
                        {
                            new AcValue() { Name = "Physical", Value = 7},
                            new AcValue() { Name = "Magic", Value = 0},
                            new AcValue() { Name = "Power", Value = 1}
                        }
                    }
                },
                PoolAbilites = new List<PoolAbility>()
                {
                    new PoolAbility()
                    {
                        Name = "Life",
                        Total = 150,
                        Talisman = 0,
                        Self = 150,
                        MedCharges = 0
                    },
                    new PoolAbility()
                    {
                        Name = "Power",
                        Total = 237,
                        Talisman = 25,
                        Self = 225,
                        MedCharges = 2
                    }
                },
                ChargedAbilities = new List<ChargedAbility>()
                { 
                },
                CharacterMagic = null,
            };
        }

        public static Character Khandis()
        {
            return new Character()
            {
                Details = new CharacterDetails()
                {
                    Name = "Khandis Greyspider",
                    Points = 2630,
                    ResChances = 2,
                    PlayerClass = PcClass.Wizard,
                    CharacterRace = PcRace.Elf,
                    CharacterArmour = new Armour()
                    {
                        Values = new List<AcValue>()
                        {
                            new AcValue() { Name = "Physical", Value = 13},
                            new AcValue() { Name = "Magic", Value = 2},
                            new AcValue() { Name = "Power", Value = 16},
                            new AcValue() { Name = "Undead", Value = 4 },
                            new AcValue() { Name = "A Dex", Value = 3}
                        }
                    }
                },
                PoolAbilites = new List<PoolAbility>()
                {
                    new PoolAbility()
                    {
                        Name = "Life",
                        Total = 177,
                        Talisman = 0,
                        Self = 0,
                        Out = 0,
                        MedCharges = 0
                    },
                    new PoolAbility()
                    {
                        Name = "Psi",
                        Total = 50,
                        Talisman = 0,
                        Out = 0,
                        Self = 50,
                        MedCharges = 1
                    }
                },
                ChargedAbilities = new List<ChargedAbility>()
                {
                    new ChargedAbility()
                    {
                        Name = "Slow Store",
                        Charges = 6,
                        Source = Source.Store,
                        Frequent = Frequency.Daily
                    },
                    new ChargedAbility()
                    {
                        Name = "Weakness Store",
                        Charges = 6,
                        Source = Source.Store,
                        Frequent = Frequency.Daily
                    },
                    new ChargedAbility()
                    {
                        Name = "Warlocks Armoury",
                        Charges = 2,
                        Source = Source.Store,
                        Frequent = Frequency.Daily
                    },
                    new ChargedAbility()
                    {
                        Name = "Sorcerours Dispell",
                        Charges = 2,
                        Source = Source.Store,
                        Frequent = Frequency.Daily
                    },
                    new ChargedAbility()
                    {
                        Name = "Kings Resist",
                        Charges = 1,
                        Source = Source.Ability,
                        Frequent = Frequency.Daily
                    },
                    new ChargedAbility()
                    {
                        Name = "1-8 Resist",
                        Charges = 2,
                        Source = Source.Ability,
                        Frequent = Frequency.Daily
                    },
                    new ChargedAbility()
                    {
                        Name = "Battle Magic Master",
                        Charges = 3,
                        Source = Source.Ability,
                        Frequent = Frequency.Daily
                    },
                    new ChargedAbility()
                    {
                        Name = "Good Spirit Heal",
                        Charges = 1,
                        Source = Source.Item,
                        Frequent = Frequency.Daily
                    },
                    new ChargedAbility()
                    {
                        Name = "Resist Disarm",
                        Charges = 1,
                        Source = Source.Item,
                        Frequent = Frequency.Daily
                    },
                    new ChargedAbility()
                    {
                        Name = "Resist Dismember",
                        Charges = 1,
                        Source = Source.Item,
                        Frequent = Frequency.Daily
                    },
                    new ChargedAbility()
                    {
                        Name = "Resist Bonebreak",
                        Charges = 1,
                        Source = Source.Item,
                        Frequent = Frequency.Daily
                    },
                    new ChargedAbility()
                    {
                        Name = "Vocal 6/7/8",
                        Charges = 3,
                        Source = Source.Ability,
                        Frequent = Frequency.Daily
                    },
                    new ChargedAbility()
                    {
                        Name = "Stored Skin",
                        Charges = 1,
                        Source = Source.Store,
                        Frequent = Frequency.Daily
                    },
                    new ChargedAbility()
                    {
                        Name = "Stored Dispell 8",
                        Charges = 1,
                        Source = Source.Store,
                        Frequent = Frequency.Daily
                    },
                    new ChargedAbility()
                    {
                        Name = "Shroud of Ushaz",
                        Charges = 1,
                        Source = Source.Item,
                        Frequent = Frequency.PerEvent
                    },
                    new ChargedAbility()
                    {
                        Name = "Darkhome Resists",
                        Charges = 10,
                        Source = Source.Ability,
                        Frequent = Frequency.PerEvent
                    },
                    new ChargedAbility()
                    {
                        Name = "Power Weapon 8",
                        Charges = 1,
                        Source = Source.Item,
                        Frequent = Frequency.OnceEver
                    },
                    new ChargedAbility()
                    {
                        Name = "Heal",
                        Charges = 2,
                        Source = Source.Item,
                        Frequent = Frequency.OnceEver
                    },
                    new ChargedAbility()
                    {
                        Name = "Cure 7",
                        Charges = 2,
                        Source = Source.Item,
                        Frequent = Frequency.OnceEver
                    },
                    new ChargedAbility()
                    {
                        Name = "Remove Paralysis",
                        Charges = 2,
                        Source = Source.Item,
                        Frequent = Frequency.OnceEver
                    },
                    new ChargedAbility()
                    {
                        Name = "Prot Disease",
                        Charges = 2,
                        Source = Source.Item,
                        Frequent = Frequency.OnceEver
                    },
                    new ChargedAbility()
                    {
                        Name = "Cure Blindness",
                        Charges = 2,
                        Source = Source.Item,
                        Frequent = Frequency.OnceEver
                    },
                    new ChargedAbility()
                    {
                        Name = "Cure Balm",
                        Charges = 3,
                        Source = Source.Item,
                        Frequent = Frequency.OnceEver
                    },
                    new ChargedAbility()
                    {
                        Name = "Prot Psi",
                        Charges = 3,
                        Source = Source.Item,
                        Frequent = Frequency.OnceEver
                    },
                    new ChargedAbility()
                    {
                        Name = "Remove G Curse",
                        Charges = 1,
                        Source = Source.Item,
                        Frequent = Frequency.OnceEver
                    },
                },
                CharacterMagic = new MagicDetails()
                {
                    SpellSlots = new List<SpellSlots>()
                    {
                        new SpellSlots() {Level = 1, Total = 263, Out = 0},
                        new SpellSlots() {Level = 2, Total = 5, Out = 0},
                        new SpellSlots() {Level = 3, Total = 7, Out = 0},
                        new SpellSlots() {Level = 4, Total = 5, Out = 0},
                        new SpellSlots() {Level = 5, Total = 39, Out = 12},
                        new SpellSlots() {Level = 6, Total = 24, Out = 2},
                        new SpellSlots() {Level = 7, Total = 8, Out = 3},
                        new SpellSlots() {Level = 8, Total = 17, Out = 13},
                        new SpellSlots() {Level = 9, Total = 6, Out = 6 },
                        new SpellSlots() {Level = 10, Total = 16, Out = 16},
                    },
                    Mnemonics = 1,
                    Regain = 526
                }
            };
        }
    }
}
