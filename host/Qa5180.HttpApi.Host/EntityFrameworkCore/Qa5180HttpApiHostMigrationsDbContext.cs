using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Qa5180.EntityFrameworkCore;

public class Qa5180HttpApiHostMigrationsDbContext : AbpDbContext<Qa5180HttpApiHostMigrationsDbContext>
{
    public Qa5180HttpApiHostMigrationsDbContext(DbContextOptions<Qa5180HttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureQa5180();
    }
}
