using King.AbpVnextPro.File.Localization;
using Volo.Abp.Application.Services;

namespace King.AbpVnextPro.File;

public abstract class FileAppService : ApplicationService
{
    protected FileAppService()
    {
        LocalizationResource = typeof(FileResource);
        ObjectMapperContext = typeof(FileApplicationModule);
    }
}
