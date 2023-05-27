using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Naz.Abp.AuditReader.Application
{
    [DependsOn(typeof(AuditApplicationContractsModule))]
    public class AuditApplicationModule: AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<AuditApplicationModule>();
            });
        }
    }
}
