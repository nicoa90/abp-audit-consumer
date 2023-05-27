using Naz.Abp.AuditReader.Dtos;
using System;
using Volo.Abp.Application.Services;

namespace Naz.Abp.AuditReader
{
    public interface IAuditLogAppService : IReadOnlyAppService<AuditLogDto, Guid, AuditLogRequestDto>
    {
    }
}
