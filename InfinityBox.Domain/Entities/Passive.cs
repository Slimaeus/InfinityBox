using InfinityBox.Domain.Common;

namespace InfinityBox.Domain.Entities
{
    public class Passive : BaseNameEntity
    {
        public ICollection<Effect> Effects { get; set; }
    }
}
