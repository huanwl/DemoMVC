using System.Linq;

namespace DemoMVC.Repository
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();

        T GetById(string id);

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);

        void SaveChange();
    }
}