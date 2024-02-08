using Traversal.DataAccessLayer.Abstract;
using Traversal.DataAccessLayer.Concrete.Repository;
using Traversal.DataAccessLayer.Context;
using Traversal.EntityLayer.Concrete;

namespace Traversal.DataAccessLayer.Concrete.EntityFramework
{
    internal class EFDestinationDAL : GenericRepository<Destination>, IDestinationDAL
    {
        public EFDestinationDAL(TraversalContext context) : base(context)
        {
        }
    }
}