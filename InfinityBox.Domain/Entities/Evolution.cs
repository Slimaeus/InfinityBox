using InfinityBox.Domain.Common;

namespace InfinityBox.Domain.Entities
{
    public class Evolution : BaseNameEntity
    {
        public int LevelRequired { get; set; }
        public CharacterType CharacterType { get; set; }
        public ICollection<Item> Materials { get; set; }
    }
}
