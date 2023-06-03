using Qa5180.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Qa5180;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(Qa5180EntityFrameworkCoreTestModule)
    )]
public class Qa5180DomainTestModule : AbpModule
{

}
