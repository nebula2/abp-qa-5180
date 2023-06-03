using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.Identity;
using Qa5180.FooBar;
using System.Threading.Tasks;
using Volo.Abp;
using Microsoft.Extensions.DependencyInjection;

namespace Qa5180;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(Qa5180DomainSharedModule)
)]
[DependsOn(typeof(AbpIdentityDomainModule))]
public class Qa5180DomainModule : AbpModule
{
    public override async Task OnApplicationInitializationAsync(ApplicationInitializationContext context)
    {
        IFooBarUserService testService = context.ServiceProvider
            .GetRequiredService<IFooBarUserService>();

        await testService.DoSomethingAsync();
    }
}
