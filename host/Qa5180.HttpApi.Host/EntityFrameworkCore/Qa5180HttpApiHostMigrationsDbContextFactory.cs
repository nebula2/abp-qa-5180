using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Qa5180.EntityFrameworkCore;

public class Qa5180HttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<Qa5180HttpApiHostMigrationsDbContext>
{
    public Qa5180HttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<Qa5180HttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Qa5180"));

        return new Qa5180HttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
