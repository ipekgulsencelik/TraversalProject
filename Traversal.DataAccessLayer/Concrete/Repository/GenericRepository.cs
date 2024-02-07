using Traversal.DataAccessLayer.Abstract;
using Traversal.DataAccessLayer.Context;
using Traversal.EntityLayer.Abstract;

namespace Traversal.DataAccessLayer.Concrete.Repository
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class, IEntity, new()
    {
        private readonly TraversalContext _context;

        public GenericRepository(TraversalContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Delete(T entity)
        {
            EnsureNotNull(entity, nameof(entity));

            _context.Set<T>().Remove(entity);
            SaveChanges();
        }

        public T GetByID(int id)
        {
            EnsureValidID(id);

            return _context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            EnsureNotNull(entity, nameof(entity));

            _context.Set<T>().Add(entity);
            SaveChanges();
        }

        public void Update(T entity)
        {
            EnsureNotNull(entity, nameof(entity));

            _context.Set<T>().Update(entity);
            SaveChanges();
        }

        private void EnsureNotNull(object argument, string paramName)
        {
            if (argument == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        private void EnsureValidID(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Invalid ID", nameof(id));
            }
        }

        private void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}