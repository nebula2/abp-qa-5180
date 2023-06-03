using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Qa5180;

[DependsOn(
    typeof(Qa5180ApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class Qa5180HttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(Qa5180ApplicationContractsModule).Assembly,
            Qa5180RemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<Qa5180HttpApiClientModule>();
        });

    }
}
