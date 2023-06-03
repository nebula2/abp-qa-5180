using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.Identity.EntityFrameworkCore;

namespace Qa5180.EntityFrameworkCore;

public static class Qa5180DbContextModelCreatingExtensions
{
    public static void ConfigureQa5180(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.ConfigureIdentity();

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(Qa5180DbProperties.DbTablePrefix + "Questions", Qa5180DbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */
    }
}
