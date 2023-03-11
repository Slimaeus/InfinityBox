using InfinityBox.Domain.Common;

namespace InfinityBox.Domain.Entities
{
    public class UserBank : BaseEntity<Guid>
    {
        public Guid UserId { get; set; }
        public int Coins { get; set; }
    }
}
