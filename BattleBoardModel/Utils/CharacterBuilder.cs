using BattleBoardModel.Model;

namespace BattleBoardModel.Utils
{
    public class CharacterBuilder
    {

        public static IEnumerable<Character> BuildAllCharacters()
        {
            return new List<Character>()
            {
                DemoCharacter(),
                Igor(),
                Albert(),
                Khandis(),
                Drokal(),
                MrNeko(),
                Gravesong(),
                Kreeper(),
                Driedyn(),
                Hak(),
                Layla(),
                Xernes(),
                Caradac(),
                Blaze(),
                Scortch()
            };
        }

        public static Character BuildCharacter()
        {
            return Igor();
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
                        MedCharges = 0,
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
                        Name = "Ki",
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
                        Name = "Dismiss Undead",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Do the Thing",
                        Charges = 1,
                        Frequent = Frequency.Sectional,
                        Source = Source.Item
                    },
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
                    },
                    new ChargedAbility()
                    {
                        Name = "This Ability Name is very Long",
                        Charges = 5,
                        Frequent = Frequency.OnceEver,
                        Source = Source.Item
                    }
                },
                CharacterMagic = new MagicDetails()
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

        public static Character Drokal()
        {
            return new Character()
            {
                Details = new CharacterDetails()
                {
                    Name = "Drokal Greyspire",
                    Points = 2702,
                    ResChances = 5,
                    CharacterRace = PcRace.Human,
                    PlayerClass = PcClass.Priest,
                    CharacterArmour = new Armour()
                    {
                        Values = new List<AcValue>()
                        {
                            new AcValue { Name = "Physical", Value = 18 },
                            new AcValue { Name = "Magic", Value = 6 },
                            new AcValue { Name = "Power", Value = 11 },
                            new AcValue { Name = "A Dex", Value = 12 },
                            new AcValue { Name = "Psy", Value = 4 }
                        }
                    }
                },
                PoolAbilites = new List<PoolAbility>()
                {
                    new PoolAbility()
                    {
                        Name = "Life",
                        Total = 201,
                        Talisman = 0,
                        Self = 0,
                        MedCharges = 0,
                        HasOut = false
                    },
                    new PoolAbility() {
                        Name = "Power",
                        Total = 300,
                        Talisman = 294,
                        Self = 6,
                        MedCharges = 2,
                        HasOut = true,
                        Out = 45
                    },
                    new PoolAbility()
                    {
                        Name = "Psi",
                        Total = 410,
                        Talisman = 0,
                        Self = 410,
                        MedCharges = 1,
                        HasOut = true,
                        Out = 58
                    }
                },
                ChargedAbilities = new List<ChargedAbility>()
                {
                    new ChargedAbility()
                    {
                        Name = "Instant Med",
                        Charges = 1,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Sorcerers Dispel",
                        Charges = 1,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Item
                    },
                     new ChargedAbility()       {
                        Name = "GS Bloodpact",
                        Charges = 1,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Ability
                    },
                    new ChargedAbility()  {
                        Name = "Dispel 5",
                        Charges = 3,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Ability
                    },
                    new ChargedAbility() {
                        Name = "Spiritual Balance",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility() {
                        Name = "King Resist 1-5",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility() {
                        Name = "Chaos Gift, absorb 1-5",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Hand of Darkness",
                        Charges = 5,
                        Frequent = Frequency.OnceEver,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Stone of Dismember",
                        Charges = 1,
                        Frequent = Frequency.OnceEver,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Fireskin 7",
                        Charges = 1,
                        Frequent = Frequency.OnceEver,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Prot Cold 7",
                        Charges = 2,
                        Frequent = Frequency.OnceEver,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Firebolt 7",
                        Charges = 5,
                        Frequent = Frequency.OnceEver,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Remove Pain",
                        Charges = 2,
                        Frequent = Frequency.OnceEver,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Resist Pain",
                        Charges = 10,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Resist Fear",
                        Charges = 10,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Spiritual Balance 9",
                        Charges = 1,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Store
                    },
                     new ChargedAbility()
                    {
                        Name = "Greater Mindshield",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                      new ChargedAbility()
                    {
                        Name = "Sorcerers Dispel 9",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                       new ChargedAbility()
                    {
                        Name = "Psi Cure 9",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                        new ChargedAbility()
                    {
                        Name = "Neurocosmic Flare",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                },
                CharacterMagic = null
            };
        }

        public static Character MrNeko()
        {
            return new Character()
            {
                Details = new CharacterDetails()
                {
                    Name = "Mr Neko",
                    Points = 1050,
                    ResChances = 4,
                    CharacterRace = PcRace.Human,
                    PlayerClass = PcClass.Scout,
                    CharacterArmour = new Armour()
                    {
                        Values = new List<AcValue>()
                        {
                            new AcValue { Name = "U Dex", Value = 16 },
                        }
                    }
                },
                PoolAbilites = new List<PoolAbility>()
                {
                    new PoolAbility()
                    {
                        Name = "Life",
                        Total = 201,
                        Talisman = 0,
                        Self = 0,
                        MedCharges = 0,
                        HasOut = false
                    },
                    new PoolAbility() {
                        Name = "Power",
                        Total = 30,
                        Talisman = 0,
                        Self = 30,
                        MedCharges = 1,
                        HasOut = false,
                        Out = 0
                    },
                    new PoolAbility()
                    {
                        Name = "Kai",
                        Total = 200,
                        Talisman = 0,
                        Self = 200,
                        MedCharges = 1,
                        HasOut = false
                    }
                },
                ChargedAbilities = new List<ChargedAbility>()
                {
                    new ChargedAbility()
                    {
                        Name = "Cat Nap Power (8)",
                        Charges = 6,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Cat Nap Ki (50)",
                        Charges = 6,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                     new ChargedAbility()       {
                        Name = "Ki Protect Magic",
                        Charges = 6,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()  {
                        Name = "Halt 7",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility() {
                        Name = "Repel Life",
                        Charges = 3,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Item
                    }
                },
                CharacterMagic = new MagicDetails()
                {
                    SpellSlots = new List<SpellSlots>()
                    {
                        new SpellSlots() {Level = 1, Total = 1, Out = 0},
                        new SpellSlots() {Level = 2, Total = 1, Out = 0},
                        new SpellSlots() {Level = 3, Total = 2, Out = 0},
                        new SpellSlots() {Level = 4, Total = 1, Out = 0},
                        new SpellSlots() {Level = 5, Total = 4, Out = 0},
                        new SpellSlots() {Level = 6, Total = 1, Out = 0},
                        new SpellSlots() {Level = 7, Total = 1, Out = 0},
                        new SpellSlots() {Level = 8, Total = 3, Out = 0},
                        new SpellSlots() {Level = 9, Total = 0, Out = 0},
                        new SpellSlots() {Level = 10, Total = 0, Out = 0}
                    },
                    Mnemonics = 1,
                    Regain = 48
                }
            };
        }

        public static Character Gravesong()
        {
            return new Character()
            {
                Details = new CharacterDetails()
                {
                    Name = "Gravesong",
                    Points = 3902,
                    ResChances = 3,
                    CharacterRace = PcRace.HalfOrc,
                    PlayerClass = PcClass.Warrior,
                    CharacterArmour = new Armour()
                    {
                        Values = new List<AcValue>()
                        {
                            new AcValue { Name = "Physical", Value = 20 },
                            new AcValue { Name = "Magic", Value = 13 },
                            new AcValue { Name = "Power", Value = 5 },
                            new AcValue { Name = "A Dex", Value = 16 },
                        }
                    }
                },
                PoolAbilites = new List<PoolAbility>()
                {
                    new PoolAbility()
                    {
                        Name = "Life",
                        Total = 405,
                        Talisman = 0,
                        Self = 0,
                        MedCharges = 0,
                        HasOut = false
                    },
                    new PoolAbility() {
                        Name = "Power",
                        Total = 5,
                        Talisman = 0,
                        Self = 5,
                        MedCharges = 2,
                        HasOut = true,
                        Out = 75
                    }
                },
                ChargedAbilities = new List<ChargedAbility>()
                {
                    new ChargedAbility()
                    {
                        Name = "Resist Disarm",
                        Charges = 6,
                        Frequent = Frequency.Sectional,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Resist Knockback",
                        Charges = 6,
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
                        Name = "Resist Knockdown",
                        Charges = 6,
                        Frequent = Frequency.Sectional,
                        Source = Source.Ability
                    },
                    new ChargedAbility() {
                        Name = "Resist Nervestrike",
                        Charges = 6,
                        Frequent = Frequency.Sectional,
                        Source = Source.Ability
                    },
                    new ChargedAbility() {
                        Name = "Resist Bonebreak",
                        Charges = 2,
                        Frequent = Frequency.Sectional,
                        Source = Source.Ability
                    },
                    new ChargedAbility() {
                        Name = "Resist Shield Arm BB",
                        Charges = 2,
                        Frequent = Frequency.Sectional,
                        Source = Source.Ability
                    },
                    new ChargedAbility() {
                        Name = "Resist shield cleve",
                        Charges = 2,
                        Frequent = Frequency.Sectional,
                        Source = Source.Ability
                    },
                    new ChargedAbility() {
                        Name = "Embers of Destruction",
                        Charges = 1,
                        Frequent = Frequency.Sectional,
                        Source = Source.Ability
                    },
                    new ChargedAbility() {
                        Name = "Resist Through",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility() {
                        Name = "Resist Dismember",
                        Charges = 2,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility() {
                        Name = "Hold the Line",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility() {
                        Name = "Never Surrender",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility() {
                        Name = " Never Say Die",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility() {
                        Name = "Immunity Disease",
                        Charges = 10,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility() {
                        Name = "Staff Ice/Shroud/Heal",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility() {
                        Name = "Static 5->3",
                        Charges = 1,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Absorb Firebolt 6-8",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Restore 1 * all warrior skills",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "BodyGuard (Khandis)",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    }
                },
                CharacterMagic = null
            };
        }

        public static Character Kreeper()
        {
            return new Character()
            {
                Details = new CharacterDetails()
                {
                    Name = "Kreeper",
                    Points = 850,
                    ResChances = 4,
                    CharacterRace = PcRace.Elf,
                    PlayerClass = PcClass.Wizard,
                    CharacterArmour = new Armour()
                    {
                        Values = new List<AcValue>()
                        {
                            new AcValue { Name = "A Dex", Value = 1 },
                        }
                    }
                },
                PoolAbilites = new List<PoolAbility>()
                {
                    new PoolAbility()
                    {
                        Name = "Life",
                        Total = 132,
                        Talisman = 0,
                        Self = 0,
                        MedCharges = 2,
                        HasOut = false
                    },
                    new PoolAbility() {
                        Name = "Power",
                        Total = 5,
                        Talisman = 0,
                        Self = 5,
                        MedCharges = 0,
                        HasOut = false,
                        Out = 0
                    }
                },
                ChargedAbilities = new List<ChargedAbility>()
                {
                },
                CharacterMagic = new MagicDetails()
                {
                    SpellSlots = new List<SpellSlots>()
                    {
                        new SpellSlots() {Level = 1, Total = 85, Out = 0},
                        new SpellSlots() {Level = 2, Total = 6, Out = 0},
                        new SpellSlots() {Level = 3, Total = 6, Out = 0},
                        new SpellSlots() {Level = 4, Total = 6, Out = 0},
                        new SpellSlots() {Level = 5, Total = 42, Out = 0},
                        new SpellSlots() {Level = 6, Total = 1, Out = 0},
                        new SpellSlots() {Level = 7, Total = 10, Out = 0},
                        new SpellSlots() {Level = 8, Total = 12, Out = 0},
                        new SpellSlots() {Level = 9, Total = 2, Out = 0},
                        new SpellSlots() {Level = 10, Total = 0, Out = 0},
                    },
                    Mnemonics = 1,
                    Regain = 185
                }
            };
        }

        public static Character Driedyn()
        {
            return new Character()
            {
                Details = new CharacterDetails()
                {
                    Name = "Driedyn",
                    Points = 4918,
                    ResChances = 4,
                    CharacterRace = PcRace.Human,
                    PlayerClass = PcClass.Priest,
                    CharacterArmour = new Armour()
                    {
                        Values = new List<AcValue>()
                        {
                            new AcValue { Name = "Physical", Value = 21 },
                            new AcValue { Name = "Magic", Value = 21 },
                            new AcValue { Name = "Power", Value = 25 },
                            new AcValue { Name = "A Dex", Value = 15 },
                            new AcValue { Name = "Undead", Value = 4 },
                            new AcValue { Name = "Evil", Value = 4 },
                            new AcValue { Name = "Psy", Value = 10 }
                        }
                    }
                },
                PoolAbilites = new List<PoolAbility>()
                {
                    new PoolAbility()
                    {
                        Name = "Life",
                        Total = 201,
                        Talisman = 0,
                        Self = 0,
                        MedCharges = 0,
                        HasOut = false
                    },
                    new PoolAbility() {
                        Name = "Power",
                        Total = 400,
                        Talisman = 400,
                        Self = 0,
                        MedCharges = 2,
                        HasOut = false,
                        Out = 0
                    }
                },
                ChargedAbilities = new List<ChargedAbility>()
                {
                    new ChargedAbility()
                    {
                        Name = "Scroll Insta Med",
                        Charges = 2,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Scroll Spirit Balance 8",
                        Charges = 2,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Item
                    },
                     new ChargedAbility()       {
                        Name = "Additional Med",
                        Charges = 1,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Item
                    },
                    new ChargedAbility()  {
                        Name = "Cure Balm 10",
                        Charges = 5,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Item
                    },
                    new ChargedAbility() {
                        Name = "Heal",
                        Charges = 3,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Item
                    },
                    new ChargedAbility() {
                        Name = "Instant Med",
                        Charges = 1,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Item
                    },
                    new ChargedAbility() {
                        Name = "Remove Pain",
                        Charges = 2,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Good Spirit Heal",
                        Charges = 1,
                        Frequent = Frequency.OnceEver,
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
                        Name = "Resist Disarm",
                        Charges = 5,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Item
                    },
                     new ChargedAbility()
                    {
                        Name = "Resist Nervestrike",
                        Charges = 5,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Free Speech",
                        Charges = 5,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Thunderclap Boon",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility()
                    {
                        Name = "Arm of Might",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility()
                    {
                        Name = "Cure Mortal",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility()
                    {
                        Name = "Spiritual Balance 9",
                        Charges = 2,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility()
                    {
                        Name = "Heal Gloves",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },


                    new ChargedAbility()
                    {
                        Name = "Instant Med",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility()
                    {
                        Name = "Spirit of Balance",
                        Charges = 1,
                        Frequent = Frequency.Sectional,
                        Source = Source.Store
                    },
                    new ChargedAbility()
                    {
                        Name = "Wizard Dispel",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility()
                    {
                        Name = "Sorcerers Dispel",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility()
                    {
                        Name = "Dispel 8",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility()
                    {
                        Name = "Shield of Air 7",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility()
                    {
                        Name = "Heal",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility()
                    {
                        Name = "Cure 8",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility()
                    {
                        Name = "Cure Fatal",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility()
                    {
                        Name = "Weapon of Woe 8",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility()
                    {
                        Name = "Cause Mortal",
                        Charges = 4,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility()
                    {
                        Name = "Master of Spheres 9 & 10",
                        Charges = 2,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility()
                    {
                        Name = "Power Gift 9",
                        Charges = 15,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility()
                    {
                        Name = "Power Gift 9",
                        Charges = 15,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility()
                    {
                        Name = "Thunderclap",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility()
                    {
                        Name = "Repulsion",
                        Charges = 10,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },


                    new ChargedAbility()
                    {
                        Name = "Cast Through Pain",
                        Charges = 10,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Resist Dismember",
                        Charges = 3,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Resist Bonebreak",
                        Charges = 3,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Resist Nervestrike",
                        Charges = 3,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Resist SA Bonebreak",
                        Charges = 3,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Resist Blue/Yellow 1-5",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Resist Death",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Resist Alignment Effect",
                        Charges = 10,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Mystics Resist",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Resist Fear/Terror",
                        Charges = 10,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Resist Shield Cleve",
                        Charges = 3,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Immunity to Web effect",
                        Charges = 10,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                },
                CharacterMagic = new MagicDetails()
                {
                    SpellSlots = new List<SpellSlots>()
                    {
                        new SpellSlots() {Level = 1, Total = 1, Out = 0},
                        new SpellSlots() {Level = 2, Total = 5, Out = 0},
                        new SpellSlots() {Level = 3, Total = 5, Out = 0},
                        new SpellSlots() {Level = 4, Total = 5, Out = 0},
                        new SpellSlots() {Level = 5, Total = 61, Out = 11},
                        new SpellSlots() {Level = 6, Total = 1, Out = 1},
                        new SpellSlots() {Level = 7, Total = 2, Out = 2},
                        new SpellSlots() {Level = 8, Total = 4, Out = 4},
                        new SpellSlots() {Level = 9, Total = 3, Out = 3},
                        new SpellSlots() {Level = 10, Total = 2, Out = 2},
                    },
                    Mnemonics = 1,
                    Regain = 245
                }
            };
        }

        public static Character Hak()
        {
            return new Character()
            {
                Details = new CharacterDetails()
                {
                    Name = "Hak Treekiller",
                    Points = 1948,
                    ResChances = 4,
                    CharacterRace = PcRace.Human,
                    PlayerClass = PcClass.Warrior,
                    CharacterArmour = new Armour()
                    {
                        Values = new List<AcValue>()
                        {
                            new AcValue { Name = "Physical", Value = 24 },
                            new AcValue { Name = "Magic", Value = 10 },
                            new AcValue { Name = "Power", Value = 13 },
                            new AcValue { Name = "A Dex", Value = 10 },
                            new AcValue { Name = "Evil", Value = 6 }
                        }
                    }
                },
                PoolAbilites = new List<PoolAbility>()
                {
                    new PoolAbility()
                    {
                        Name = "Life",
                        Total = 354,
                        Talisman = 0,
                        Self = 0,
                        MedCharges = 0,
                        HasOut = false
                    },
                    new PoolAbility() {
                        Name = "Power",
                        Total = 6,
                        Talisman = 0,
                        Self = 6,
                        MedCharges = 0,
                        HasOut = false,
                        Out = 0
                    },
                    new PoolAbility()
                    {
                        Name = "Adrenals",
                        Total = 15,
                        Talisman = 0,
                        Self = 15,
                        MedCharges = 0,
                        HasOut = false
                    }
                },
                ChargedAbilities = new List<ChargedAbility>()
                {
                    new ChargedAbility()
                    {
                        Name = "Resist Disarm",
                        Charges = 3,
                        Frequent = Frequency.Sectional,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Resist Knockback",
                        Charges = 3,
                        Frequent = Frequency.Sectional,
                        Source = Source.Ability
                    },
                    new ChargedAbility() {
                        Name = "Resist Shield Cleve",
                        Charges = 1,
                        Frequent = Frequency.Sectional,
                        Source = Source.Ability
                    },
                    new ChargedAbility() {
                        Name = "Resist Dismember",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility() {
                        Name = "Body Pump",
                        Charges = 3,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility() {
                        Name = "Resist Disease",
                        Charges = 5,
                        Frequent = Frequency.Sectional,
                        Source = Source.Ability
                    },
                    new ChargedAbility() {
                        Name = "AC Bastion",
                        Charges = 3,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Heal",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Resist SC/SABB",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Extra GS",
                        Charges = 1,
                        Frequent = Frequency.OnceEver,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Cure 7",
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
                        Name = "Heal",
                        Charges = 3,
                        Frequent = Frequency.OnceEver,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Mind Shield",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    }
                },
                CharacterMagic = null
            };
        }

        public static Character Xernes()
        {
            return new Character()
            {
                Details = new CharacterDetails()
                {
                    Name = "Xernes",
                    Points = 1970,
                    ResChances = 1,
                    CharacterRace = PcRace.HalfOrc,
                    PlayerClass = PcClass.Priest,
                    CharacterArmour = new Armour()
                    {
                        Values = new List<AcValue>()
                        {
                            new AcValue { Name = "Physical", Value = 10 },
                            new AcValue { Name = "Magic", Value = 2 },
                            new AcValue { Name = "Power", Value = 2 },
                            new AcValue { Name = "A Dex", Value = 17 }
                        }
                    }
                },
                PoolAbilites = new List<PoolAbility>()
                {
                    new PoolAbility()
                    {
                        Name = "Life",
                        Total = 201,
                        Talisman = 0,
                        Self = 0,
                        MedCharges = 0,
                        HasOut = false
                    },
                    new PoolAbility() {
                        Name = "Power",
                        Total = 300,
                        Talisman = 267,
                        Self = 33,
                        MedCharges = 1,
                        HasOut = true,
                        Out = 165
                    }
                },
                ChargedAbilities = new List<ChargedAbility>()
                {
                    new ChargedAbility()
                    {
                        Name = "Cause Fatal",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility()
                    {
                        Name = "Cause Mortal",
                        Charges = 5,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                     new ChargedAbility()       {
                        Name = "Power Steal 9",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility()  {
                        Name = "Cure Major Disease",
                        Charges = 1,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Item
                    },
                    new ChargedAbility() {
                        Name = "Shocking Grasp 6",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility() {
                        Name = "Beguile 7",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility() {
                        Name = "Life Steal 8",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Life Steal 7",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Entrapment 8",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Firebolt 7",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Poison Anti 10",
                        Charges = 1,
                        Frequent = Frequency.OnceEver,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Remove G Curse",
                        Charges = 1,
                        Frequent = Frequency.OnceEver,
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
                        Name = "Double Strength",
                        Charges = 1,
                        Frequent = Frequency.OnceEver,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Cast through staff",
                        Charges = 4,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    }
                },
                CharacterMagic = new MagicDetails()
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

        public static Character Layla()
        {
            return new Character()
            {
                Details = new CharacterDetails()
                {
                    Name = "Dame Layla Mayfield",
                    Points = 1590,
                    ResChances = 4,
                    CharacterRace = PcRace.Human,
                    PlayerClass = PcClass.Warrior,
                    CharacterArmour = new Armour()
                    {
                        Values = new List<AcValue>()
                        {
                            new AcValue { Name = "Physical", Value = 18 },
                            new AcValue { Name = "Magic", Value = 12 },
                            new AcValue { Name = "Power", Value = 5 },
                            new AcValue { Name = "A Dex", Value = 4 },
                        }
                    }
                },
                PoolAbilites = new List<PoolAbility>()
                {
                    new PoolAbility()
                    {
                        Name = "Life",
                        Total = 303,
                        Talisman = 0,
                        Self = 0,
                        MedCharges = 0,
                        HasOut = false
                    },
                    new PoolAbility() {
                        Name = "Power",
                        Total = 32,
                        Talisman = 32,
                        Self = 0,
                        MedCharges = 1,
                        HasOut = false,
                        Out = 0
                    }
                },
                ChargedAbilities = new List<ChargedAbility>()
                {
                    new ChargedAbility()
                    {
                        Name = "Knockback",
                        Charges = 1,
                        Frequent = Frequency.Sectional,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Res Bone Break",
                        Charges = 1,
                        Frequent = Frequency.Sectional,
                        Source = Source.Ability
                    },
                     new ChargedAbility()       {
                        Name = "Resist Shield Cleve",
                        Charges = 1,
                        Frequent = Frequency.Sectional,
                        Source = Source.Ability
                    },
                    new ChargedAbility()  {
                        Name = "Resist SA BB",
                        Charges = 1,
                        Frequent = Frequency.Sectional,
                        Source = Source.Ability
                    },
                    new ChargedAbility() {
                        Name = "Mass Cure Mortal",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility() {
                        Name = "Bless 6",
                        Charges = 4,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility() {
                        Name = "Walk on air 4",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Cause Mortal",
                        Charges = 3,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Enhanced Reflexes 7",
                        Charges = 1,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Potion Remove G Curse",
                        Charges = 3,
                        Frequent = Frequency.OnceEver,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Reflect Rk/lvl 1-8",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Res 1-5 Grn/Wht",
                        Charges = 10,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Good Spirit Heal",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Immutable Shield",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                },
                CharacterMagic = null
            };
        }

        public static Character Blaze()
        {
            return new Character()
            {
                Details = new CharacterDetails()
                {
                    Name = "Blaze",
                    Points = 1430,
                    ResChances = 1,
                    CharacterRace = PcRace.Elf,
                    PlayerClass = PcClass.Wizard,
                    CharacterArmour = new Armour()
                    {
                        Values = new List<AcValue>()
                        {
                            new AcValue { Name = "Physical", Value = 18 },
                            new AcValue { Name = "Magic", Value = 13 },
                            new AcValue { Name = "Power", Value = 6 },
                            new AcValue { Name = "A Dex", Value = 8 },
                            new AcValue { Name = "Evil", Value = 1 },
                            new AcValue { Name = "Psi", Value = 10 }
                        }
                    }
                },
                PoolAbilites = new List<PoolAbility>()
                {
                    new PoolAbility()
                    {
                        Name = "Life",
                        Total = 129,
                        Talisman = 0,
                        Self = 0,
                        MedCharges = 0,
                        HasOut = false
                    },
                    new PoolAbility() {
                        Name = "Power",
                        Total = 5,
                        Talisman = 0,
                        Self = 5,
                        MedCharges = 0,
                        HasOut = false,
                        Out = 0
                    },
                    new PoolAbility() {
                        Name = "Mana Store",
                        Total = 63,
                        Talisman = 0,
                        Self = 0,
                        MedCharges = 0,
                        HasOut = false,
                        Out = 0
                    },
                     new PoolAbility() {
                        Name = "Psi",
                        Total = 20,
                        Talisman = 0,
                        Self = 0,
                        MedCharges = 1,
                        HasOut = false,
                        Out = 0
                    }
                },
                ChargedAbilities = new List<ChargedAbility>()
                {
                    new ChargedAbility()
                    {
                        Name = "Flameblade 8",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Neuro Cosmic Flair",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                     new ChargedAbility()       {
                        Name = "Fools Dice",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility()  {
                        Name = "Amulet of Immolation",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility() {
                        Name = "Speak with animate",
                        Charges = 2,
                        Frequent = Frequency.OnceEver,
                        Source = Source.Item
                    },
                    new ChargedAbility() {
                        Name = "Cure Balm 10 pts",
                        Charges = 1,
                        Frequent = Frequency.OnceEver,
                        Source = Source.Item
                    },
                    new ChargedAbility() {
                        Name = "Cure Mortal",
                        Charges = 1,
                        Frequent = Frequency.OnceEver,
                        Source = Source.Item
                    },
                    new ChargedAbility() {
                        Name = "Cause Mortal",
                        Charges = 1,
                        Frequent = Frequency.OnceEver,
                        Source = Source.Item
                    },

                    new ChargedAbility() {
                        Name = "Wizard Dispel",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility() {
                        Name = "Sorcerors Dispel 9/10",
                        Charges = 2,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    }
                },
                CharacterMagic = new MagicDetails()
                {
                    SpellSlots = new List<SpellSlots>()
                    {
                        new SpellSlots() {Level = 1, Total = 143, Out = 0},
                        new SpellSlots() {Level = 2, Total = 15, Out = 0},
                        new SpellSlots() {Level = 3, Total = 15, Out = 0},
                        new SpellSlots() {Level = 4, Total = 8, Out = 0},
                        new SpellSlots() {Level = 5, Total = 40, Out = 0},
                        new SpellSlots() {Level = 6, Total = 2, Out = 0},
                        new SpellSlots() {Level = 7, Total = 2, Out = 0},
                        new SpellSlots() {Level = 8, Total = 8, Out = 0},
                        new SpellSlots() {Level = 9, Total = 3, Out = 0},
                        new SpellSlots() {Level = 10, Total = 5, Out = 0},
                    },
                    Mnemonics = 1,
                    Regain = 243
                }
            };
        }

        public static Character Caradac()
        {
            return new Character()
            {
                Details = new CharacterDetails()
                {
                    Name = "Caradac Fireapple",
                    Points = 5384,
                    ResChances = 5,
                    CharacterRace = PcRace.Human,
                    PlayerClass = PcClass.Scout,
                    CharacterArmour = new Armour()
                    {
                        Values = new List<AcValue>()
                        {
                            new AcValue { Name = "Physical", Value = 4 },
                            new AcValue { Name = "Magic", Value = 10 },
                            new AcValue { Name = "Power", Value = 11 },
                            new AcValue { Name = "U Dex", Value = 32 }
                        }
                    }
                },
                PoolAbilites = new List<PoolAbility>()
                {
                    new PoolAbility()
                    {
                        Name = "Life",
                        Total = 276,
                        Talisman = 0,
                        Self = 0,
                        MedCharges = 0,
                        HasOut = false
                    },
                    new PoolAbility() {
                        Name = "Power",
                        Total = 179,
                        Talisman = 179,
                        Self = 0,
                        MedCharges = 1,
                        HasOut = true,
                        Out = 95
                    },
                    new PoolAbility()
                    {
                        Name = "Ki",
                        Total = 160,
                        Talisman = 160,
                        Self = 0,
                        MedCharges = 0,
                        HasOut = true,
                        Out = 43
                    }
                },
                ChargedAbilities = new List<ChargedAbility>()
                {
                    new ChargedAbility()
                    {
                        Name = "Ki Focus Magic",
                        Charges = 8,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Ki Focus Power",
                        Charges = 8,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                     new ChargedAbility()       {
                        Name = "Embody Earth Elemental",
                        Charges = 1,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Item
                    },
                    new ChargedAbility()  {
                        Name = "Remove G Curse",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility() {
                        Name = "Destroy Magic 6",
                        Charges = 2,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility() {
                        Name = "Destroy Magic 7",
                        Charges = 2,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility() {
                        Name = "Destroy Magic 8",
                        Charges = 2,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    },
                    new ChargedAbility() {
                        Name = "BV 4",
                        Charges = 3,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Item
                    },
                    new ChargedAbility() {
                        Name = "Weapon of Woe 7",
                        Charges = 1,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Item
                    },
                    new ChargedAbility() {
                        Name = "Scroll Paper",
                        Charges = 1,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Thunderclap",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Instant Psi Invk",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Ki Protection",
                        Charges = 12,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Resist Poison Effect",
                        Charges = 9,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Dodge",
                        Charges = 3,
                        Frequent = Frequency.Sectional,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Psi Cure 9",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility()
                    {
                        Name = "Psi Rapid Fortification 9",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    },
                    new ChargedAbility()
                    {
                        Name = "Aura of Neurocosmic Repulsion",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Store
                    }
                },
                CharacterMagic = new MagicDetails()
                {
                    SpellSlots = new List<SpellSlots>()
                    {
                        new SpellSlots() {Level = 1, Total = 1, Out = 0},
                        new SpellSlots() {Level = 2, Total = 4, Out = 0},
                        new SpellSlots() {Level = 3, Total = 1, Out = 0},
                        new SpellSlots() {Level = 4, Total = 1, Out = 0},
                        new SpellSlots() {Level = 5, Total = 4, Out = 0},
                        new SpellSlots() {Level = 6, Total = 1, Out = 0},
                        new SpellSlots() {Level = 7, Total = 1, Out = 0},
                        new SpellSlots() {Level = 8, Total = 1, Out = 0},
                        new SpellSlots() {Level = 9, Total = 0, Out = 0},
                        new SpellSlots() {Level = 10, Total = 0, Out = 0},
                    },
                    Mnemonics = 1,
                    Regain = 250
                }
            };
        }

        public static Character Scortch()
        {
            return new Character()
            {
                Details = new CharacterDetails()
                {
                    Name = "Scortch",
                    Points = 1372,
                    ResChances = 3,
                    CharacterRace = PcRace.HalfOrc,
                    PlayerClass = PcClass.Scout,
                    CharacterArmour = new Armour()
                    {
                        Values = new List<AcValue>()
                        {
                            new AcValue { Name = "Magic", Value = 8 },
                            new AcValue { Name = "Power", Value = 6 },
                            new AcValue { Name = "U Dex", Value = 23 },
                            new AcValue { Name = "Awareness", Value = 12 }
                        }
                    }
                },
                PoolAbilites = new List<PoolAbility>()
                {
                    new PoolAbility()
                    {
                        Name = "Life",
                        Total = 237,
                        Talisman = 0,
                        Self = 0,
                        MedCharges = 0,
                        HasOut = false
                    },
                    new PoolAbility() {
                        Name = "Power",
                        Total = 25,
                        Talisman = 0,
                        Self = 25,
                        MedCharges = 1,
                        HasOut = false,
                        Out = 0
                    }
                },
                ChargedAbilities = new List<ChargedAbility>()
                {
                    new ChargedAbility()
                    {
                        Name = "HQ Dex Store",
                        Charges = 10,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "HQ Dex Store",
                        Charges = 10,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "HQ Exotic Poison 1-5",
                        Charges = 5,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "HQ Exotic Poison 6-8",
                        Charges = 3,
                        Frequent = Frequency.Daily,
                        Source = Source.Ability
                    },
                    new ChargedAbility()
                    {
                        Name = "Sleep 7",
                        Charges = 1,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Darkbolt",
                        Charges = 1,
                        Frequent = Frequency.PerEvent,
                        Source = Source.Item
                    },
                    new ChargedAbility()
                    {
                        Name = "Potion Philter",
                        Charges = 1,
                        Frequent = Frequency.Daily,
                        Source = Source.Item
                    }
                },
                CharacterMagic = null
            };
        }
    }
}
