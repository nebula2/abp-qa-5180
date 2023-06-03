using System;
using System.Threading.Tasks;
using Xunit;

namespace Qa5180.FooBar;

public class FooBarTests : Qa5180DomainTestBase
{
    private readonly IFooBarUserService _userService;
    public FooBarTests()
    {
        _userService = GetRequiredService<IFooBarUserService>();
    }

    [Fact]
    public async Task ShouldDoSomething()
    {
        Exception ex = await Record.ExceptionAsync(_userService.DoSomethingAsync);

        Assert.Null(ex);
    }
}