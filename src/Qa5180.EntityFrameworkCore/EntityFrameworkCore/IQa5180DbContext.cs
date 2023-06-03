using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Qa5180.EntityFrameworkCore;

[ConnectionStringName(Qa5180DbProperties.ConnectionStringName)]
public interface IQa5180DbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
