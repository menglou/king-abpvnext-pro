using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.Openiddict.Volo.Identity
{
    public class UseToOrganizationUnitDeleteDto : EntityDto
    {
        public Guid UserId { get; set; }
        public Guid OrgId { get; set; }
    }
}
