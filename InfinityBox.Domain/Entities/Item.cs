using InfinityBox.Domain.Common;
using InfinityBox.Domain.Enums;

namespace InfinityBox.Domain.Entities
{
    public class Item : BaseEntity
    {
        public ItemType ItemType { get; set; }
    }
}
