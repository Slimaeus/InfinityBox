using InfinityBox.Domain.Common;

namespace InfinityBox.Domain.Entities;

public class Stat
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Value { get; set; }
}
