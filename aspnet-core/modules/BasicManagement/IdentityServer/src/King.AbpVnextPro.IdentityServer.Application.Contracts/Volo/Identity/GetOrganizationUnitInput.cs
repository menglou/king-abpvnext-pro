﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.IdentityServer.Volo.Identity
{
    public class GetOrganizationUnitInput : PagedAndSortedResultRequestDto
    {
        public Guid? ParentId { get; set; }
        public string Filter { get; set; }
    }
}
