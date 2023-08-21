using King.AbpVnextPro.File.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace King.AbpVnextPro.File;

public abstract class FileController : AbpControllerBase
{
    protected FileController()
    {
        LocalizationResource = typeof(FileResource);
    }
}
