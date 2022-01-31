using Acme.DataAccess.Converters;
using Acme.DataAccess.Entities;
using Acme.DataAccess.Services;
using Acme.Domain.DTOs;

namespace Acme.DataAccess.Repositories
{
    public class CRUDRepository<KEntity, TDTO>
        where KEntity : Entity
        where TDTO : DTO
    {
        private IConverter _toEntity;
        private IConverter _fromEntity;
        private IService<KEntity> _service;

        public CRUDRepository(
            IConverter toEntity,
            IConverter fromEntity,
            IService<KEntity> service) 
        {
            _toEntity = toEntity;
            _fromEntity = fromEntity;
            _service = service;
        }

        public TDTO Create(TDTO obj)
        {
            var entity = _toEntity.Convert<TDTO, KEntity>(obj);
            var result = _service.Create(entity);
            return _fromEntity.Convert<KEntity, TDTO>(result);
        }

        public bool Delete(long id)
        {
            return _service.Delete(id);
        }

        public TDTO Get(long id)
        {
            var result = _service.Get(id);
            return _fromEntity.Convert<KEntity, TDTO>(result);
        }

        public bool Update(TDTO obj)
        {
            var entity = _toEntity.Convert<TDTO, KEntity>(obj);
            return _service.Update(entity);
        }
    }
}
