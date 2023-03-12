using InfinityBox.Domain.Entities;
using InfinityBox.Domain.Enums;

namespace InfinityBox.Infrastructure.SeedData
{
    public static class EffectStatModiers
    {
        public static List<EffectStatModifier> List = new List<EffectStatModifier>
        {
            new EffectStatModifier { Effect = Effects.PhysicalAttack, StatModifier = StatModifiers.BasicPhysicalAttack, Type = EffectStatModifierType.Source },
            new EffectStatModifier { Effect = Effects.PhysicalAttack, StatModifier = StatModifiers.BasicPhysicalDefence, Type = EffectStatModifierType.Source },
            new EffectStatModifier { Effect = Effects.PhysicalAttack, StatModifier = StatModifiers.BasicHP, Type = EffectStatModifierType.Destination },

            new EffectStatModifier { Effect = Effects.MagicalAttack, StatModifier = StatModifiers.BasicMagicalAttack, Type = EffectStatModifierType.Source },
            new EffectStatModifier { Effect = Effects.MagicalAttack, StatModifier = StatModifiers.BasicMagicalDefence, Type = EffectStatModifierType.Source },
            new EffectStatModifier { Effect = Effects.MagicalAttack, StatModifier = StatModifiers.BasicHP, Type = EffectStatModifierType.Destination },

            new EffectStatModifier { Effect = Effects.Heal, StatModifier = StatModifiers.BasicMagicalAttack, Type = EffectStatModifierType.Source },
            new EffectStatModifier { Effect = Effects.Heal, StatModifier = StatModifiers.BasicHP, Type = EffectStatModifierType.Destination },

            new EffectStatModifier { Effect = Effects.Burn, StatModifier = StatModifiers.BasicMagicalOverTime, Type = EffectStatModifierType.Source },
            new EffectStatModifier { Effect = Effects.Burn, StatModifier = StatModifiers.BasicMagicalDefence, Type = EffectStatModifierType.Source },
            new EffectStatModifier { Effect = Effects.Burn, StatModifier = StatModifiers.BasicHP, Type = EffectStatModifierType.Destination },

            new EffectStatModifier { Effect = Effects.Poison, StatModifier = StatModifiers.BasicMagicalOverTime, Type = EffectStatModifierType.Source },
            new EffectStatModifier { Effect = Effects.Poison, StatModifier = StatModifiers.BasicMagicalDefence, Type = EffectStatModifierType.Source },
            new EffectStatModifier { Effect = Effects.Poison, StatModifier = StatModifiers.BasicHP, Type = EffectStatModifierType.Destination },

            new EffectStatModifier { Effect = Effects.Bleeding, StatModifier = StatModifiers.BasicMagicalOverTime, Type = EffectStatModifierType.Source },
            new EffectStatModifier { Effect = Effects.Bleeding, StatModifier = StatModifiers.BasicMagicalDefence, Type = EffectStatModifierType.Source },
            new EffectStatModifier { Effect = Effects.Bleeding, StatModifier = StatModifiers.BasicHP, Type = EffectStatModifierType.Destination },

            new EffectStatModifier { Effect = Effects.BoostPhysicalAttack, StatModifier = StatModifiers.DoublePhysicalAttack, Type = EffectStatModifierType.Source },

            new EffectStatModifier { Effect = Effects.BoostMagicalAttack, StatModifier = StatModifiers.DoubleMagicalAttack, Type = EffectStatModifierType.Source },

            new EffectStatModifier { Effect = Effects.BoostHP, StatModifier = StatModifiers.BasicMaxHP, Type = EffectStatModifierType.Source },

        };
    }
}
