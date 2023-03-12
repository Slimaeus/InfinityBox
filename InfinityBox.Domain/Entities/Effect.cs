using InfinityBox.Domain.Common;
using InfinityBox.Domain.Enums;

namespace InfinityBox.Domain.Entities;

public class Effect : BaseNameEntity
{
    public EffectType Type { get; set; }
    public TargetType TargetType { get; set; }
    public int Duration { get; set; }
    public ICollection<EffectStatModifier> EffectStatModifiers { get; set; }
    public ICollection<Skill> Skills { get; set; }
    public ICollection<Passive> Passives { get; set; }
}
