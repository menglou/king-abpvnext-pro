using King.AbpVnextPro.Notice.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace King.AbpVnextPro.Notice;

public abstract class NoticeController : AbpControllerBase
{
    protected NoticeController()
    {
        LocalizationResource = typeof(NoticeResource);
    }
}
