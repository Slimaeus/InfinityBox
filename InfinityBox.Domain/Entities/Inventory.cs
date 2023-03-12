using InfinityBox.Domain.Common;

namespace InfinityBox.Domain.Entities;

public class Inventory : BaseGuidEntity
{
    public Guid UserId { get; set; }
    public ICollection<Item> Items { get; set; }
}
