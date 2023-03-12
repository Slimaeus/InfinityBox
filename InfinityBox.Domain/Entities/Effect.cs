using InfinityBox.Domain.Common;
using InfinityBox.Domain.Enums;

namespace InfinityBox.Domain.Entities;

public class Effect : BaseEntity
{
    public EffectType Type { get; set; }
    public TargetType TargetType { get; set; }
    public int Duration { get; set; }
    public ICollection<EffectStatModifier> EffectStatModifiers { get; set; }
}
