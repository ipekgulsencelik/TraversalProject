using Traversal.EntityLayer.Abstract;

namespace Traversal.EntityLayer.Concrete
{
    public class Testimonial : BaseEntity, IEntity
    {
        public string? Client { get; set; }
        public string? Comment { get; set; }
        public string? ClientImage { get; set; }
    }
}
