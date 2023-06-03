using Qa5180.Localization;
using Volo.Abp.Application.Services;

namespace Qa5180;

public abstract class Qa5180AppService : ApplicationService
{
    protected Qa5180AppService()
    {
        LocalizationResource = typeof(Qa5180Resource);
        ObjectMapperContext = typeof(Qa5180ApplicationModule);
    }
}
