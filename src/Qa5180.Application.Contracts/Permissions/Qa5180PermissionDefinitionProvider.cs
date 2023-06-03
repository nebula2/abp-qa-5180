using Qa5180.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Qa5180.Permissions;

public class Qa5180PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Qa5180Permissions.GroupName, L("Permission:Qa5180"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Qa5180Resource>(name);
    }
}
