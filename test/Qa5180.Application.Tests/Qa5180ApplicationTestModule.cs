using Volo.Abp.Modularity;

namespace Qa5180;

[DependsOn(
    typeof(Qa5180ApplicationModule),
    typeof(Qa5180DomainTestModule)
    )]
public class Qa5180ApplicationTestModule : AbpModule
{

}
