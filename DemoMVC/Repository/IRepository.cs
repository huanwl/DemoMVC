using System.Linq;

namespace DemoMVC.Repository
{
    public interface IRepository<T>
    {
        string Create(T entity);

        string Delete(T entity);

        IQueryable<T> GetAll();

        T GetById(string id);

        void Update(T entity);

        void SaveChange();
    }
}