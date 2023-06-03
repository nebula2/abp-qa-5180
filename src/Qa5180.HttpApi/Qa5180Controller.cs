using Qa5180.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Qa5180;

public abstract class Qa5180Controller : AbpControllerBase
{
    protected Qa5180Controller()
    {
        LocalizationResource = typeof(Qa5180Resource);
    }
}
