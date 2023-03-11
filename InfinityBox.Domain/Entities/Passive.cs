using InfinityBox.Domain.Common;

namespace InfinityBox.Domain.Entities
{
    public class Passive : BaseEntity
    {
        public ICollection<Effect> Effects { get; set; }
    }
}
