using Traversal.EntityLayer.Abstract;

namespace Traversal.EntityLayer.Concrete
{
    public class SubAbout : BaseEntity, IEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}