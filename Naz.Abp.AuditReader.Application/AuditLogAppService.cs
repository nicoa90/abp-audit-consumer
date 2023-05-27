using Volo.Abp.AuditLogging;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Application.Services;
using Naz.Abp.AuditReader.Dtos;

namespace Naz.Abp.AuditReader
{
    public class AuditAppService : ReadOnlyAppService<AuditLog, AuditLogDto, Guid, AuditLogRequestDto>, IAuditLogAppService
    {
        private readonly IRepository<AuditLog, Guid> _repository;
        public AuditAppService(
            IRepository<AuditLog, Guid> repository)
            : base(repository)
        {
            _repository = repository;
        }

        protected override async Task<AuditLog> GetEntityByIdAsync(Guid id)
        {
            var result = await _repository.GetAsync(id, includeDetails: true);
            return result;
        }
    }
}
