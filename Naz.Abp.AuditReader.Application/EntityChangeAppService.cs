
using Naz.Abp.AuditReader.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.AuditLogging;
using Volo.Abp.Domain.Repositories;


namespace Naz.Abp.AuditReader
{
    public class EntityChangeAppService : ReadOnlyAppService<EntityChange, EntityChangeDto, Guid, EntityChangeRequestDto>, IEntityChangeAppService
    {
        IRepository<EntityChange, Guid> _repository = null;
        public EntityChangeAppService(
            IRepository<EntityChange, Guid> repository)
            : base(repository)
        {
            _repository = repository;
        }
        protected override async Task<EntityChange> GetEntityByIdAsync(Guid id)
        {
            //var result = await _repository.GetAsync(id, includeDetails: true);
            //return result;
            var response = await ReadOnlyRepository.WithDetailsAsync(x => x.PropertyChanges);
            return response.Where(x => x.Id == id).FirstOrDefault();
        }

        protected override async Task<IQueryable<EntityChange>> CreateFilteredQueryAsync(EntityChangeRequestDto input)
        {
            var queryable = await ReadOnlyRepository.WithDetailsAsync(x => x.PropertyChanges);
            return queryable;
        }
    }
}
