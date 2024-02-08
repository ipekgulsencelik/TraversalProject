using Traversal.DataAccessLayer.Abstract;
using Traversal.DataAccessLayer.Concrete.Repository;
using Traversal.DataAccessLayer.Context;
using Traversal.EntityLayer.Concrete;

namespace Traversal.DataAccessLayer.Concrete.EntityFramework
{
    public class EFGuideDAL : GenericRepository<Guide>, IGuideDAL
    {
        public EFGuideDAL(TraversalContext context) : base(context)
        {
        }
    }
}