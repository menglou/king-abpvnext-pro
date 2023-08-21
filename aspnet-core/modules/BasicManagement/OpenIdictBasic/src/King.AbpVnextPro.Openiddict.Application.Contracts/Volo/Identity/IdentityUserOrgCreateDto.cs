using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Identity;

namespace King.AbpVnextPro.Openiddict.Volo.Identity
{
    public class IdentityUserOrgCreateDto : IdentityUserCreateDto
    {
        public List<Guid> OrgIds { get; set; }
    }
}
