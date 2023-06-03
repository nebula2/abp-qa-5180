using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Qa5180;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(Qa5180DomainSharedModule)
)]
public class Qa5180DomainModule : AbpModule
{

}
