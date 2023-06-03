using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Qa5180.MongoDB;

[ConnectionStringName(Qa5180DbProperties.ConnectionStringName)]
public interface IQa5180MongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
