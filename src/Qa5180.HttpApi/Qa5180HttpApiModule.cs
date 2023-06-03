using Localization.Resources.AbpUi;
using Qa5180.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Qa5180;

[DependsOn(
    typeof(Qa5180ApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class Qa5180HttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(Qa5180HttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<Qa5180Resource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
