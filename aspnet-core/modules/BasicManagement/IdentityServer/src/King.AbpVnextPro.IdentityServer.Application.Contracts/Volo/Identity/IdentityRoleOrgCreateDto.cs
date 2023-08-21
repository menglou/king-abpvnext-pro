using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Identity;

namespace King.AbpVnextPro.IdentityServer.Volo.Identity
{
    public class IdentityRoleOrgCreateDto : IdentityRoleCreateDto
    {
        public IdentityRoleOrgCreateDto()
        {

        }

        public Guid? OrgId { get; set; }
    }
}
