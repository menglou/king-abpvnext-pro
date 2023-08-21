using King.AbpVnextPro.Dictionary.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace King.AbpVnextPro.Dictionary;

public abstract class DictionaryController : AbpControllerBase
{
    protected DictionaryController()
    {
        LocalizationResource = typeof(DictionaryResource);
    }
}
