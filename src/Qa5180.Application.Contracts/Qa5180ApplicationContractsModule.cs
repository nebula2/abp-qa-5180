using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Qa5180;

[DependsOn(
    typeof(Qa5180DomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class Qa5180ApplicationContractsModule : AbpModule
{

}
