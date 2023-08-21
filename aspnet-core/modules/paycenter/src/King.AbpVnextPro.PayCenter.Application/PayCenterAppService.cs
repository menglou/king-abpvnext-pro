using King.AbpVnextPro.PayCenter.Localization;
using Volo.Abp.Application.Services;

namespace King.AbpVnextPro.PayCenter;

public abstract class PayCenterAppService : ApplicationService
{
    protected PayCenterAppService()
    {
        LocalizationResource = typeof(PayCenterResource);
        ObjectMapperContext = typeof(PayCenterApplicationModule);
    }
}
