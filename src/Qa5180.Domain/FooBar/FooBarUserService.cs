using System;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Identity;

namespace Qa5180.FooBar;

public class FooBarUserService : IFooBarUserService, ITransientDependency
{
    private readonly IdentityUserManager _identityUserManager;

    public FooBarUserService(IdentityUserManager identityUserManager)
    {
        _identityUserManager = identityUserManager;
    }

    public async Task DoSomethingAsync()
    {
        IdentityUser foo = await _identityUserManager.FindByEmailAsync("admin@abp.io");

        if (foo == null)
        {
            await Console.Out.WriteLineAsync("User not found");
            return;
        }

        await Console.Out.WriteLineAsync($"Found user {foo.UserName}");
    }
}