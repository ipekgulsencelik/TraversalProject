using Traversal.EntityLayer.Abstract;

namespace Traversal.EntityLayer.Concrete
{
    public class About2 : BaseEntity, IEntity
    {
        public string? Title1 { get; set; }
        public string? Title2 { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
    }
}
