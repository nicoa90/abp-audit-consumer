using Volo.Abp.Application.Services;
using Naz.Abp.AuditReader.Dtos;

namespace Naz.Abp.AuditReader
{
    public interface IEntityChangeAppService : IReadOnlyAppService<EntityChangeDto, Guid, EntityChangeRequestDto>
    {
    }
}
