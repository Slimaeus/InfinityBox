using InfinityBox.Domain.Common;
using InfinityBox.Domain.Enums;

namespace InfinityBox.Domain.Entities;

public class Effect : BaseEntity
{
    public EffectTypes Type { get; set; }
    public int Value { get; set; }
    public int Duration { get; set; }
}
