namespace Qa5180.EntityFrameworkCore;

/* This class can be used as a base class for EF Core integration tests,
 * while SampleRepository_Tests uses a different approach.
 */
public abstract class Qa5180EntityFrameworkCoreTestBase : Qa5180TestBase<Qa5180EntityFrameworkCoreTestModule>
{

}
