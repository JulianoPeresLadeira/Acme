using Acme.Domain.DTOs;

namespace Acme.Domain.Facades
{
    public interface IFacade<T>
        where T : DTO
    {
        T Get(long id);
        T Create(T obj);
        bool Update(T obj);
        bool Delete(long id);
    }
}
