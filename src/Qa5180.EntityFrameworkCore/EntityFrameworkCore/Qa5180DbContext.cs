using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Qa5180.EntityFrameworkCore;

[ConnectionStringName(Qa5180DbProperties.ConnectionStringName)]
public class Qa5180DbContext : AbpDbContext<Qa5180DbContext>, IQa5180DbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public Qa5180DbContext(DbContextOptions<Qa5180DbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureQa5180();
    }
}
