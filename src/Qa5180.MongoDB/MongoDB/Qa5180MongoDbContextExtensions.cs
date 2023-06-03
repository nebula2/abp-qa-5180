using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Qa5180.MongoDB;

public static class Qa5180MongoDbContextExtensions
{
    public static void ConfigureQa5180(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
