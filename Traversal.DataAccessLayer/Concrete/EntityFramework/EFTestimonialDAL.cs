using Traversal.DataAccessLayer.Abstract;
using Traversal.DataAccessLayer.Concrete.Repository;
using Traversal.DataAccessLayer.Context;
using Traversal.EntityLayer.Concrete;

namespace Traversal.DataAccessLayer.Concrete.EntityFramework
{
    internal class EFTestimonialDAL : GenericRepository<Testimonial>, ITestimonialDAL
    {
        public EFTestimonialDAL(TraversalContext context) : base(context)
        {
        }
    }
}