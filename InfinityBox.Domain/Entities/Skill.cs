using InfinityBox.Domain.Common;

namespace InfinityBox.Domain.Entities;

public class Skill : BaseEntity
{
    public int Cooldown { get; set; }
    public int Power { get; set; }
    public Effect Effect { get; set; }
}
