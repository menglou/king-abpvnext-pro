using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.IdentityServer.Volo.Identity
{
   public class BatchUseToOrganizationUnitCreationDto: EntityDto
    {
        public BatchUseToOrganizationUnitCreationDto()
        {
            UserId = new List<Guid>();
        }
        public List<Guid> UserId { get; set; }
        public Guid OrgId { get; set; }
    }
}
