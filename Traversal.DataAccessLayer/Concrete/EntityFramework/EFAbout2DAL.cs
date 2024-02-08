using Traversal.DataAccessLayer.Abstract;
using Traversal.DataAccessLayer.Concrete.Repository;
using Traversal.DataAccessLayer.Context;
using Traversal.EntityLayer.Concrete;

namespace Traversal.DataAccessLayer.Concrete.EntityFramework
{
    public class EFAbout2DAL : GenericRepository<About2>, IAbout2DAL
    {
        public EFAbout2DAL(TraversalContext context) : base(context)
        {
        }
    }
}