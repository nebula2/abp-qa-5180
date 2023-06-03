using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace Qa5180;

[DependsOn(
    typeof(Qa5180DomainModule),
    typeof(Qa5180ApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class Qa5180ApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<Qa5180ApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<Qa5180ApplicationModule>(validate: true);
        });
    }
}
