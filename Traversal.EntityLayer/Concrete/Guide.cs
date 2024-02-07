using Traversal.EntityLayer.Abstract;

namespace Traversal.EntityLayer.Concrete
{
    public class Guide : BaseEntity, IEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public string? TwitterUrl { get; set; }
        public string? InstagramUrl { get; set; }
    }
}