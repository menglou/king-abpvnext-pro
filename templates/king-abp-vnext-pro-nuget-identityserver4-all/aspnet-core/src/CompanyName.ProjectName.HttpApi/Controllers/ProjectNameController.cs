using CompanyName.ProjectName.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CompanyName.ProjectName.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ProjectNameController : AbpControllerBase
{
    protected ProjectNameController()
    {
        LocalizationResource = typeof(ProjectNameResource);
    }
}
