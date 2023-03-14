using InfinityBox.Domain.Entities;
using InfinityBox.Domain.Enums;

namespace InfinityBox.Infrastructure.SeedData
{
    public static class StatModifiers
    {
        public static readonly StatModifier DoubleMaxHP = new StatModifier
        {
            IsTarget = true,
            StatType = EffectStatType.MAX_HP,
            CalculateType = CalculateType.Multiply,
            Rate = 1,
            Type = EffectStatModifierType.Destination
        };
        public static readonly StatModifier BasicMaxHP = new StatModifier
        {
            IsTarget = true,
            StatType = EffectStatType.MAX_HP,
            CalculateType = CalculateType.Add,
            Rate = 1,
            Type = EffectStatModifierType.Destination
        };
        public static readonly StatModifier BasicHP = new StatModifier
        {
            IsTarget = true,
            StatType = EffectStatType.HP,
            CalculateType = CalculateType.Add,
            Rate = 1,
            Type= EffectStatModifierType.Destination
        };
        public static readonly StatModifier Heal = new StatModifier
        {
            IsTarget = false,
            StatType = EffectStatType.HP,
            CalculateType = CalculateType.Add,
            Rate = 0.1,
            Type = EffectStatModifierType.Source
        };
        public static readonly StatModifier DoublePhysicalAttack = new StatModifier
        {
            IsTarget = true,
            StatType = EffectStatType.KEN_ATK,
            CalculateType = CalculateType.Multiply,
            Rate = 2,
            Type = EffectStatModifierType.Destination
        };
        public static readonly StatModifier BasicPhysicalAttack = new StatModifier
        {
            IsTarget = false,
            StatType = EffectStatType.KEN_ATK,
            CalculateType = CalculateType.Subtract,
            Rate = 1,
            Type = EffectStatModifierType.Source
        };
        public static readonly StatModifier BasicPhysicalDefence = new StatModifier
        {
            IsTarget = true,
            StatType = EffectStatType.ENE_DEF,
            CalculateType = CalculateType.Add,
            Rate = 1,
            Type = EffectStatModifierType.Source
        };
        public static readonly StatModifier DoubleMagicalAttack = new StatModifier
        {
            IsTarget = true,
            StatType = EffectStatType.ENE_ATK,
            CalculateType = CalculateType.Multiply,
            Rate = 2,
            Type = EffectStatModifierType.Destination
        };
        public static readonly StatModifier BasicMagicalAttack = new StatModifier
        {
            IsTarget = false,
            StatType = EffectStatType.ENE_ATK,
            CalculateType = CalculateType.Subtract,
            Rate = 1,
            Type = EffectStatModifierType.Source
        };
        public static readonly StatModifier BasicMagicalOverTime = new StatModifier
        {
            IsTarget = false,
            StatType = EffectStatType.ENE_ATK,
            CalculateType = CalculateType.Subtract,
            Rate = 0.1,
            Type = EffectStatModifierType.Source
        };
        public static readonly StatModifier BasicMagicalDefence = new StatModifier
        {
            IsTarget = true,
            StatType = EffectStatType.ENE_DEF,
            CalculateType = CalculateType.Add,
            Rate = 1,
            Type = EffectStatModifierType.Source
        };
        public static readonly StatModifier BasicMagicalDefenceOverTime = new StatModifier
        {
            IsTarget = false,
            StatType = EffectStatType.ENE_DEF,
            CalculateType = CalculateType.Add,
            Rate = 0.1,
            Type = EffectStatModifierType.Source
        };
        public static readonly StatModifier BasicCriticalHitChance = new StatModifier
        {
            IsTarget = false,
            StatType = EffectStatType.CRT,
            CalculateType = CalculateType.Add,
            Rate = 0.05,
            Type = EffectStatModifierType.Source
        };
        public static readonly StatModifier BasicDodgeChance = new StatModifier
        {
            IsTarget = true,
            StatType = EffectStatType.EVA,
            CalculateType = CalculateType.Add,
            Rate = 0.1,
            Type = EffectStatModifierType.Source
        };
        public static readonly List<StatModifier> List = new List<StatModifier>
        {
            DoubleMaxHP,
            BasicMaxHP,
            BasicHP,
            Heal,
            DoublePhysicalAttack,
            BasicPhysicalAttack,
            BasicPhysicalDefence,
            DoubleMagicalAttack,
            BasicMagicalAttack,
            BasicMagicalOverTime,
            BasicMagicalDefence,
            BasicMagicalDefenceOverTime,
            BasicCriticalHitChance,
            BasicDodgeChance
        };
    }
}
