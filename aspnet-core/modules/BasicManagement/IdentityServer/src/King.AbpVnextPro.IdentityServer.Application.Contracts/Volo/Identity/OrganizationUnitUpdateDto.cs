using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace King.AbpVnextPro.IdentityServer.Volo.Identity
{
    public class OrganizationUnitUpdateDto : OrganizationUnitCreateOrUpdateDtoBase, IHasConcurrencyStamp
    {
        public string ConcurrencyStamp { get; set; }
    }
}
