using Traversal.EntityLayer.Abstract;

namespace Traversal.EntityLayer.Concrete
{
    public class Feature2 : BaseEntity, IEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
    }
}