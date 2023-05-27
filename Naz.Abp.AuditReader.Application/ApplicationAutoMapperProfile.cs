using Naz.Abp.AuditReader.Dtos;
using AutoMapper;
using Volo.Abp.AuditLogging;

namespace Naz.Abp.AuditReader;

public class ApplicationAutoMapperProfile : Profile
{
    public ApplicationAutoMapperProfile()
    {
        CreateMap<AuditLog, AuditLogDto>().ReverseMap();
        CreateMap<AuditLogAction, AuditLogActionsDto>().ReverseMap();
        CreateMap<EntityChange, EntityChangeDto>().ReverseMap();
        CreateMap<EntityPropertyChange, EntityPropertyChangeDto>().ReverseMap();
    }
}
