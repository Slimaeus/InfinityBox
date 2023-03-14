using InfinityBox.Domain.Entities;
using InfinityBox.Domain.Enums;

namespace InfinityBox.Infrastructure.SeedData
{
    public static class Effects
    {
        public static readonly Effect PhysicalAttack = new Effect
        {
            Id = 1,
            Type = EffectType.KineticDamage,
            Name = "Physical Attack",
            Description = "Deals physical damage to the target.",
            StatModifiers = new List<StatModifier>
            {
                StatModifiers.BasicPhysicalAttack,
                StatModifiers.BasicPhysicalDefence,
                StatModifiers.BasicMaxHP
            },
            Duration = 0
        };
        public static readonly Effect MagicalAttack = new Effect
        {
            Id = 2,
            Type = EffectType.EnergyDamage,
            Name = "Magical Attack",
            Description = "Deals magical damage to the target.",
            StatModifiers = new List<StatModifier>
            {
                StatModifiers.BasicMagicalAttack,
                StatModifiers.BasicMagicalDefence,
                StatModifiers.BasicMaxHP
            },
            Duration = 0
        };
        public static readonly Effect Heal = new Effect
        {
            Id = 3,
            Type = EffectType.Heal,
            Name = "Heal",
            Description = "Restores health to the target.",
            StatModifiers = new List<StatModifier>
            {
                StatModifiers.Heal,
                StatModifiers.BasicMaxHP
            },
            Duration = 0
        };
        public static readonly Effect Stun = new Effect
        {
            Id = 4,
            Type = EffectType.CrowdControl,
            Name = "Stun",
            Description = "Stuns the target.",
            Duration = 2
        };
        public static readonly Effect Burn = new Effect
        {
            Id = 5,
            Name = "Burn",
            Description = "Deals fire damage over time to the target.",
            Type = EffectType.DamageOverTime,
            StatModifiers = new List<StatModifier>
            {
                StatModifiers.BasicMagicalOverTime,
                StatModifiers.BasicMagicalDefenceOverTime,
                StatModifiers.BasicMaxHP
            },
            Duration = 3
        };
        public static readonly Effect Poison = new Effect
        {
            Id = 6,
            Name = "Poison",
            Description = "Deals poison damage over time to the target.",
            Type = EffectType.DamageOverTime,
            StatModifiers = new List<StatModifier>
            {
                StatModifiers.BasicMagicalOverTime,
                StatModifiers.BasicMagicalDefenceOverTime,
                StatModifiers.BasicMaxHP
            },
            Duration = 3
        };
        public static readonly Effect Bleeding = new Effect
        {
            Id = 7,
            Name = "Bleeding",
            Description = "Deals bleeding damage over time to the target.",
            Type = EffectType.DamageOverTime,
            StatModifiers = new List<StatModifier>
            {
                StatModifiers.BasicMagicalOverTime,
                StatModifiers.BasicMagicalDefenceOverTime,
                StatModifiers.BasicMaxHP
            },
            Duration = 3
        };
        public static readonly Effect Silent = new Effect
        {
            Id = 8,
            Name = "Silent",
            Description = "Silences the target.",
            Type = EffectType.CrowdControl,
            Duration = 2
        };
        public static readonly Effect BoostPhysicalAttack = new Effect
        {
            Id = 9,
            Name = "Boost Physical Attack",
            Description = "Temporarily increases physical attack.",
            Type = EffectType.Buff,
            StatModifiers = new List<StatModifier>
            {
                StatModifiers.DoublePhysicalAttack
            },
            Duration = 3
        };
        public static readonly Effect BoostMagicalAttack = new Effect
        {
            Id = 10,
            Name = "Boost Magical Attack",
            Description = "Temporarily increases magical attack.",
            Type = EffectType.Buff,
            StatModifiers = new List<StatModifier>
            {
                StatModifiers.DoubleMagicalAttack
            },
            Duration = 3
        };
        public static readonly Effect BoostHP = new Effect
        {
            Id = 11,
            Name = "Boost HP",
            Description = "Temporarily increases HP.",
            Type = EffectType.Buff,
            StatModifiers = new List<StatModifier>
            {
                StatModifiers.DoubleMaxHP
            },
            Duration = 3
        };
        //public static readonly Effect Slow = new Effect
        //{
        //    Id = 1,
        //    Type = EffectType.Debuff,
        //    Name = "Slow",
        //    Description = "Reduces the target's movement speed for a duration.",
        //    StatModifiers = new List<StatModifier>
        //    {
        //        new StatModifier { StatType = EffectStatType.SPD, CalculateType = CalculateType.Subtract, Rate = 0.1f , Type = EffectStatModifierType.Source },
        //        new StatModifier { StatType = EffectStatType.SPD, CalculateType = CalculateType.Add, Rate = 1f , Type = EffectStatModifierType.Destination },
        //    },
        //    Duration = 5
        //};
        //public static readonly Effect Haste = new Effect
        //{
        //    Id = 2,
        //    Type = EffectType.Buff,
        //    Name = "Haste",
        //    Description = "Increases the target's movement speed for a duration.",
        //    StatModifiers = new List<StatModifier>
        //    {
        //        new StatModifier { StatType = EffectStatType.SPD, CalculateType = CalculateType.Add, Rate = 0.1f , Type = EffectStatModifierType.Source },
        //        new StatModifier { StatType = EffectStatType.SPD, CalculateType = CalculateType.Add, Rate = 1f , Type = EffectStatModifierType.Destination },
        //    },
        //    Duration = 5
        //};

        //public static readonly Effect Confusion = new Effect
        //{
        //    Id = 3,
        //    Type = EffectType.Debuff,
        //    Name = "Confusion",
        //    Description = "Causes the target's actions to be randomly determined for a duration.",
        //    StatModifiers = new List<StatModifier>
        //    {
        //        new StatModifier { StatType = EffectStatType.ACC, CalculateType = CalculateType.Subtract, Rate = 0.1f , Type = EffectStatModifierType.Source },
        //        new StatModifier { StatType = EffectStatType.ACC, CalculateType = CalculateType.Add, Rate = 1f , Type = EffectStatModifierType.Destination },
        //    },
        //    Duration = 5
        //};

        //public static readonly Effect Fear = new Effect
        //{
        //    Id = 4,
        //    Type = EffectType.Debuff,
        //    Name = "Fear",
        //    Description = "Causes the target to flee from the source of the effect for a duration.",
        //    StatModifiers = new List<StatModifier>
        //    {
        //        new StatModifier { StatType = EffectStatType.ACC, CalculateType = CalculateType.Subtract, Rate = 0.2f , Type = EffectStatModifierType.Source },
        //        new StatModifier { StatType = EffectStatType.ACC, CalculateType = CalculateType.Add, Rate = 1f , Type = EffectStatModifierType.Destination },
        //    },
        //    Duration = 5
        //};

        public static readonly List<Effect> List = new List<Effect>()
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
