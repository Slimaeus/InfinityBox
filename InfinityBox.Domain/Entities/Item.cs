using InfinityBox.Domain.Common;
using InfinityBox.Domain.Enums;

namespace InfinityBox.Domain.Entities
{
    public class Item : BaseNameEntity
    {
        public ItemType ItemType { get; set; }
    }
}
