using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.Openiddict.Volo.Identity
{
   public class OrganizationUnitUsersPagedListDto: PagedAndSortedResultRequestDto
    {
        [Required]
        public Guid orgId { get; set; }
        public bool includeChildren { get; set; } = false;
    }
}
