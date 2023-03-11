using InfinityBox.Domain.Common;
using InfinityBox.Domain.Enums;

namespace InfinityBox.Domain.Entities;

public class Effect : BaseEntity
{
    public EffectTypes Type { get; set; }
    public StatType SourceType { get; set; }
    public StatType DestinationType { get; set; }
    public double Value { get; set; }
    public int Duration { get; set; }
}
