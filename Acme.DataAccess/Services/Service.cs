using Acme.DataAccess.Context;
using Acme.DataAccess.Entities;

namespace Acme.DataAccess.Services
{
    public class Service<T> : IService<T>
        where T : Entity
    {
        private PostgreSQLContext _context;

        public Service(PostgreSQLContext context)
        {
            _context = context;
        }

        public T Get(long id)
        {
            return _context.Set<T>().Find(id);
        }

        public bool Delete(long id)
        {

            T entity = _context.Set<T>().Find(id);
            if (entity != null)
            {
                _context.Remove(entity);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public T Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }
        public bool Update(T entity)
        {

            if (_context.Set<T>().Find(entity) != null)
            {
                _context.Update(entity);
                _context.SaveChanges();
                return true;
            }

            return false;

        }
    }
}
