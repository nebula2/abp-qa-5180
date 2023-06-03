using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Qa5180.MongoDB;

[ConnectionStringName(Qa5180DbProperties.ConnectionStringName)]
public class Qa5180MongoDbContext : AbpMongoDbContext, IQa5180MongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureQa5180();
    }
}
