using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Identity.MongoDB;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace Qa5180.MongoDB;

[DependsOn(
    typeof(Qa5180DomainModule),
    typeof(AbpMongoDbModule)
    )]
[DependsOn(typeof(AbpIdentityMongoDbModule))]
public class Qa5180MongoDbModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddMongoDbContext<Qa5180MongoDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
        });
    }
}
