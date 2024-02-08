using Traversal.DataAccessLayer.Abstract;
using Traversal.DataAccessLayer.Concrete.Repository;
using Traversal.DataAccessLayer.Context;
using Traversal.EntityLayer.Concrete;

namespace Traversal.DataAccessLayer.Concrete.EntityFramework
{
    public class EFFeature2DAL : GenericRepository<Feature2>, IFeature2DAL
    {
        public EFFeature2DAL(TraversalContext context) : base(context)
        {
        }
    }
}