using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.EntityLayer.Abstract;

namespace Traversal.EntityLayer.Concrete
{
    internal class Feature2 : BaseEntity, IEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
    }
}
