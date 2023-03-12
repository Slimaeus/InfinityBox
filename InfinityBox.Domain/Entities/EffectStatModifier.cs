using InfinityBox.Domain.Enums;

namespace InfinityBox.Domain.Entities
{
    public class EffectStatModifier
    {
        public int EffectId { get; set; }
        public Effect Effect { get; set; }
        public int StatModifierId { get; set; }
        public StatModifier StatModifier { get; set; }

        public EffectStatModifierType Type { get; set; }
    }
}
