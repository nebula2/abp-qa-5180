using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Qa5180;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Qa5180HttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class Qa5180ConsoleApiClientModule : AbpModule
{

}
