using Volo.Abp.Reflection;

namespace Qa5180.Permissions;

public class Qa5180Permissions
{
    public const string GroupName = "Qa5180";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(Qa5180Permissions));
    }
}
