using InfinityBox.Domain.Entities;
using InfinityBox.Domain.Enums;

namespace InfinityBox.Infrastructure.SeedData
{
    public static class Effects
    {
        public static Effect PhysicalAttack = new Effect
        {
            Id = 1,
            Type = EffectType.PhysicalDamage,
            Name = "Physical Attack",
            Description = "Deals physical damage to the target.",
            EffectStatModifiers = new List<EffectStatModifier>
            {
                new EffectStatModifier { EffectId = 1, StatModifier = StatModifiers.BasicPhysicalAttack, Type = EffectStatModifierType.Source },
                new EffectStatModifier { EffectId = 1, StatModifier = StatModifiers.BasicPhysicalDefence, Type = EffectStatModifierType.Source },
                new EffectStatModifier { EffectId = 1, StatModifier = StatModifiers.BasicHP, Type = EffectStatModifierType.Destination },
            },
            Duration = 0
        };
        public static Effect MagicalAttack = new Effect
        {
            Id = 2,
            Type = EffectType.MagicalDamage,
            Name = "Magical Attack",
            Description = "Deals magical damage to the target.",
            EffectStatModifiers = new List<EffectStatModifier>
            {
                new EffectStatModifier { EffectId = 2, StatModifier = StatModifiers.BasicMagicalAttack, Type = EffectStatModifierType.Source },
                new EffectStatModifier { EffectId = 2, StatModifier = StatModifiers.BasicMagicalDefence, Type = EffectStatModifierType.Source },
                new EffectStatModifier { EffectId = 2, StatModifier = StatModifiers.BasicHP, Type = EffectStatModifierType.Destination },
            },
            Duration = 0
        };
        public static Effect Heal = new Effect
        {
            Id = 3,
            Type = EffectType.Heal,
            Name = "Heal",
            Description = "Restores health to the target.",
            EffectStatModifiers = new List<EffectStatModifier>
            {
                new EffectStatModifier { EffectId = 3, StatModifier = StatModifiers.BasicMagicalAttack, Type = EffectStatModifierType.Source },
                new EffectStatModifier { EffectId = 3, StatModifier = StatModifiers.BasicHP, Type = EffectStatModifierType.Destination },
            },
            Duration = 0
        };
        public static Effect Stun = new Effect
        {
            Id = 4,
            Type = EffectType.Stun,
            Name = "Stun",
            Description = "Stuns the target.",
            Duration = 2
        };
        public static Effect Burn = new Effect
        {
            Id = 5,
            Name = "Burn",
            Description = "Deals fire damage over time to the target.",
            Type = EffectType.Burn,
            EffectStatModifiers = new List<EffectStatModifier>
            {
                new EffectStatModifier { EffectId = 5, StatModifier = StatModifiers.BasicMagicalOverTime, Type = EffectStatModifierType.Source },
                new EffectStatModifier { EffectId = 5, StatModifier = StatModifiers.BasicMagicalDefence, Type = EffectStatModifierType.Source },
                new EffectStatModifier { EffectId = 5, StatModifier = StatModifiers.BasicHP, Type = EffectStatModifierType.Destination },
            },
            Duration = 3
        };
        public static Effect Poison = new Effect
        {
            Id = 6,
            Name = "Poison",
            Description = "Deals poison damage over time to the target.",
            Type = EffectType.Poison,
            EffectStatModifiers = new List<EffectStatModifier>
            {
                new EffectStatModifier { EffectId = 6, StatModifier = StatModifiers.BasicMagicalOverTime, Type = EffectStatModifierType.Source },
                new EffectStatModifier { EffectId = 6, StatModifier = StatModifiers.BasicMagicalDefence, Type = EffectStatModifierType.Source },
                new EffectStatModifier { EffectId = 6, StatModifier = StatModifiers.BasicHP, Type = EffectStatModifierType.Destination },
            },
            Duration = 3
        };
        public static Effect Bleeding = new Effect
        {
            Id = 7,
            Name = "Bleeding",
            Description = "Deals bleeding damage over time to the target.",
            Type = EffectType.Bleeding,
            EffectStatModifiers = new List<EffectStatModifier>
            {
                new EffectStatModifier { EffectId = 7, StatModifier = StatModifiers.BasicMagicalOverTime, Type = EffectStatModifierType.Source },
                new EffectStatModifier { EffectId = 7, StatModifier = StatModifiers.BasicMagicalDefence, Type = EffectStatModifierType.Source },
                new EffectStatModifier { EffectId = 7, StatModifier = StatModifiers.BasicHP, Type = EffectStatModifierType.Destination },
            },
            Duration = 3
        };
        public static Effect Silent = new Effect
        {
            Id = 8,
            Name = "Silent",
            Description = "Silences the target.",
            Type = EffectType.Silent,
            Duration = 2
        };
        public static Effect BoostPhysicalAttack = new Effect
        {
            Id = 9,
            Name = "Boost Physical Attack",
            Description = "Temporarily increases physical attack.",
            Type = EffectType.Buff,
            EffectStatModifiers = new List<EffectStatModifier>
            {
                new EffectStatModifier { EffectId = 9, StatModifier = StatModifiers.DoublePhysicalAttack, Type = EffectStatModifierType.Source }
            },
            Duration = 3
        };
        public static Effect BoostMagicalAttack = new Effect
        {
            Id = 10,
            Name = "Boost Magical Attack",
            Description = "Temporarily increases magical attack.",
            Type = EffectType.Buff,
            EffectStatModifiers = new List<EffectStatModifier>
            {
                new EffectStatModifier { EffectId = 10, StatModifier = StatModifiers.DoubleMagicalAttack, Type = EffectStatModifierType.Source }
            },
            Duration = 3
        };
        public static Effect BoostHP = new Effect
        {
            Id = 11,
            Name = "Boost HP",
            Description = "Temporarily increases HP.",
            Type = EffectType.Buff,
            EffectStatModifiers = new List<EffectStatModifier>
            {
                new EffectStatModifier { EffectId = 11, StatModifier = StatModifiers.DoubleMaxHP, Type = EffectStatModifierType.Source }
            },
            Duration = 3
        };

        public static List<Effect> List = new List<Effect>()
        {
            PhysicalAttack,
            MagicalAttack,
            Heal,
            Stun,
            Burn,
            Poison,
            Bleeding,
            Silent,
            BoostPhysicalAttack
        };
    }
}
