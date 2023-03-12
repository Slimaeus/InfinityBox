using InfinityBox.Domain.Common;
using InfinityBox.Domain.Enums;

namespace InfinityBox.Domain.Entities
{
    public class StatModifier : BaseEntity
    {
        public bool IsTarget { get; set; }
        public EffectStatType StatType { get; set; }
        public CalculateType CalculateType { get; set; }
        public double Rate { get; set; }
        public ICollection<EffectStatModifier> EffectStatModifiers { get; set; }
    }
}
