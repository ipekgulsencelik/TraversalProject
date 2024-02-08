using Traversal.DataAccessLayer.Abstract;
using Traversal.DataAccessLayer.Concrete.Repository;
using Traversal.DataAccessLayer.Context;
using Traversal.EntityLayer.Concrete;

namespace Traversal.DataAccessLayer.Concrete.EntityFramework
{
    public class EFAboutDAL : GenericRepository<About>, IAboutDAL
    {
        public EFAboutDAL(TraversalContext context) : base(context)
        {
        }
    }
}