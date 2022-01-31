using Acme.DataAccess.Entities;

namespace Acme.DataAccess.Services
{
    public interface IService<T>
        where T : Entity
    {
        T Get(long id);
        T Create(T obj);
        bool Update(T obj);
        bool Delete(long id);
    }
}
