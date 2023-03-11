using InfinityBox.Domain.Common;

namespace InfinityBox.Domain.Entities;

public class Inventory : BaseEntity<Guid>
{
    public Guid UserId { get; set; }
    public ICollection<Item> Items { get; set; }
}
