using Traversal.DataAccessLayer.Abstract;
using Traversal.DataAccessLayer.Concrete.Repository;
using Traversal.DataAccessLayer.Context;
using Traversal.EntityLayer.Concrete;

namespace Traversal.DataAccessLayer.Concrete.EntityFramework
{
    internal class EFFeatureDAL : GenericRepository<Feature>, IFeatureDAL
    {
        public EFFeatureDAL(TraversalContext context) : base(context)
        {
        }
    }
}