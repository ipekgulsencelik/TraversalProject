using Traversal.EntityLayer.Abstract;

namespace Traversal.EntityLayer.Concrete
{
    public class Newsletter : BaseEntity, IEntity
    {
        public string? Mail { get; set; }
    }
}