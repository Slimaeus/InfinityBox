using InfinityBox.Domain.Entities;
using InfinityBox.Domain.Enums;

namespace InfinityBox.Infrastructure.SeedData
{
    public static class StatModifiers
    {
        public static StatModifier BasicPhysicalAttack = new StatModifier
        {
            Id = 1,
            IsTarget = false,
            StatType = EffectStatType.PHY_ATK,
            CalculateType = CalculateType.Subtract,
            Rate = 1
        };
        public static StatModifier DoublePhysicalAttack = new StatModifier
        {
            Id = 2,
            IsTarget = true,
            StatType = EffectStatType.PHY_ATK,
            CalculateType = CalculateType.Multiply,
            Rate = 2
        };
        public static StatModifier DoubleMaxHP = new StatModifier
        {
            Id = 3,
            IsTarget = true,
            StatType = EffectStatType.MAX_HP,
            CalculateType = CalculateType.Multiply,
            Rate = 1
        };
        public static StatModifier DoubleMagicalAttack = new StatModifier
        {
            Id = 4,
            IsTarget = true,
            StatType = EffectStatType.MAG_ATK,
            CalculateType = CalculateType.Multiply,
            Rate = 2
        };
        public static StatModifier BasicMagicalAttack = new StatModifier
        {
            Id = 5,
            IsTarget = false,
            StatType = EffectStatType.MAG_ATK,
            CalculateType = CalculateType.Subtract,
            Rate = 1
        };
        public static StatModifier BasicMagicalOverTime = new StatModifier
        {
            Id = 6,
            IsTarget = false,
            StatType = EffectStatType.MAG_ATK,
            CalculateType = CalculateType.Subtract,
            Rate = 0.1
        };
        public static StatModifier BasicPhysicalDefence = new StatModifier
        {
            Id = 7,
            IsTarget = true,
            StatType = EffectStatType.MAG_DEF,
            CalculateType = CalculateType.Add,
            Rate = 1
        };
        public static StatModifier BasicMagicalDefence = new StatModifier
        {
            Id = 8,
            IsTarget = true,
            StatType = EffectStatType.MAG_DEF,
            CalculateType = CalculateType.Add,
            Rate = 1
        };
        public static StatModifier BasicMaxHP = new StatModifier
        {
            Id = 9,
            IsTarget = true,
            StatType = EffectStatType.MAX_HP,
            CalculateType = CalculateType.Add,
            Rate = 1
        };
        public static StatModifier BasicHP = new StatModifier
        {
            Id = 10,
            IsTarget = true,
            StatType = EffectStatType.HP,
            CalculateType = CalculateType.Add,
            Rate = 1
        };

        public static List<StatModifier> List = new List<StatModifier>
        {
            BasicHP,
            BasicMagicalAttack,
            BasicMagicalDefence,
            BasicMaxHP,
            BasicPhysicalAttack,
            BasicPhysicalDefence,
            BasicMagicalOverTime,
            DoubleMagicalAttack,
            DoublePhysicalAttack,
            DoubleMaxHP
        };
    }
}
