using Traversal.EntityLayer.Abstract;

namespace Traversal.DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class, IEntity
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetList();
        T GetByID(int id);
    }
}