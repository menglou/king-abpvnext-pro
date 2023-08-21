using King.AbpVnextPro.Dictionary.Localization;
using Volo.Abp.Application.Services;

namespace King.AbpVnextPro.Dictionary;

public abstract class DictionaryAppService : ApplicationService
{
    protected DictionaryAppService()
    {
        LocalizationResource = typeof(DictionaryResource);
        ObjectMapperContext = typeof(DictionaryApplicationModule);
    }
}
