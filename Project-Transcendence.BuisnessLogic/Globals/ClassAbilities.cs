using Project_Transcendence.BuisnessLogic.Models.Character.CharacterImplementations.States;
using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;
using static Project_Transcendence.BuisnessLogic.Globals.GlobalEnums;

namespace Project_Transcendence.BuisnessLogic.Globals
{
    public static class ClassAbilities
    {
        public static readonly List<IAbility> _MonkAbilities = new()
        {
            new Ability()
            {
                Id = 1,
                Name = "Soothing Meditation",
                Description = "Mnich wchodzi w stan głębokiej medytacji, regenerując zdrowie.",
                Healing = 50,
                Damage = 0,
                ResourceCost = 10,
                Type = AbilityType.Monk,
                Resource = ResourceType.Chi,
                AbilityPower = StateType.None,
                EffectOccurChance = 100
            },
            new Ability()
            {
                Id = 2,
                Name = "Chi Strike",
                Description = "Quick attack using chi energy that has 10% chance to stun your enemy for 1 turn",
                Healing = 0,
                Damage = 30,
                ResourceCost = 15,
                Type = AbilityType.Monk,
                Resource = ResourceType.Chi,
                AbilityPower = StateType.None,
                EffectOccurChance = 100,
                State = new StunState()
                {
                    Name = "Stun",
                    Description = "Target is stunned for 1 turn.",
                    Duration = 1
                }
            },
            new Ability()
            {
                Id = 3,
                Name = "Dragon's Breath",
                Description = "Might breath of fire that deals 50dmg now and sets the target aflame dealing 50dmg in 5 turns.",
                Healing = 0,
                Damage = 50,
                ResourceCost = 30,
                Type = AbilityType.Monk,
                Resource = ResourceType.Chi,
                AbilityPower = StateType.DamageOverTime,
                EffectOccurChance = 100,
                State = new DoTState()
                {
                    Name = "Dragon's Breath",
                    Description = "Target is burning for 50dmg in 5 turns.",
                    Duration = 5,
                    Damage = 50
                }
            },
            new Ability()
            {
                Id = 4,
                Name = "Palm Strike",
                Description = "Punches target with his palm egenerating 1 chi",
                Healing = 50,
                Damage = 5,
                ResourceCost = 10,
                Type = AbilityType.Monk,
                Resource = ResourceType.Chi,
                AbilityPower = StateType.Generator,
                EffectOccurChance = 100
            }
        };

        public static readonly List<IAbility> _WarriorAbilities = new()
        {
            new Ability()
            {

            },
            new Ability()
            {

            },
            new Ability()
            {

            },
            new Ability()
            {

            }
        };

        public static readonly List<IAbility> _WizardAbilities = new()
        {
            new Ability()
            {

            },
            new Ability()
            {

            },
            new Ability()
            {

            },
            new Ability()
            {

            }
        };

        static readonly List<IAbility> _RogueAbilities = new()
        {
            new Ability()
            {

            },
            new Ability()
            {

            },
            new Ability()
            {

            },
            new Ability()
            {

            }
        };
    }
}
