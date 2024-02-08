using Traversal.DataAccessLayer.Abstract;
using Traversal.DataAccessLayer.Concrete.Repository;
using Traversal.DataAccessLayer.Context;
using Traversal.EntityLayer.Concrete;

namespace Traversal.DataAccessLayer.Concrete.EntityFramework
{
    public class EFSubAboutDAL : GenericRepository<SubAbout>, ISubAboutDAL
    {
        public EFSubAboutDAL(TraversalContext context) : base(context)
        {
        }
    }
}