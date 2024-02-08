using Traversal.DataAccessLayer.Abstract;
using Traversal.DataAccessLayer.Concrete.Repository;
using Traversal.DataAccessLayer.Context;
using Traversal.EntityLayer.Concrete;

namespace Traversal.DataAccessLayer.Concrete.EntityFramework
{
    public class EFNewsletterDAL : GenericRepository<Newsletter>, INewsletterDAL
    {
        public EFNewsletterDAL(TraversalContext context) : base(context)
        {
        }
    }
}