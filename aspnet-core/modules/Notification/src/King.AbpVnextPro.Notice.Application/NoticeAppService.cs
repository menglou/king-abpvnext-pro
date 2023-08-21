using King.AbpVnextPro.Notice.Localization;
using Volo.Abp.Application.Services;

namespace King.AbpVnextPro.Notice;

public abstract class NoticeAppService : ApplicationService
{
    protected NoticeAppService()
    {
        LocalizationResource = typeof(NoticeResource);
        ObjectMapperContext = typeof(NoticeApplicationModule);
    }
}
