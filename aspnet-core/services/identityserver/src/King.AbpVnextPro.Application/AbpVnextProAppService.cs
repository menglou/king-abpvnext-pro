using System;
using System.Collections.Generic;
using System.Text;
using King.AbpVnextPro.Localization;
using Volo.Abp.Application.Services;

namespace King.AbpVnextPro;

/* Inherit your application services from this class.
 */
public abstract class AbpVnextProAppService : ApplicationService
{
    protected AbpVnextProAppService()
    {
        LocalizationResource = typeof(AbpVnextProResource);
    }
}
