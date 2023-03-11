using InfinityBox.Domain.Common;

namespace InfinityBox.Domain.Entities;

public class Stat : BaseEntity
{
    public StatType StatType { get; set; }
    public int Value { get; set; }
}
