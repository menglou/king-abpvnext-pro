using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Identity;

namespace King.AbpVnextPro.Institution.Departments
{
    public class GetIdentityUsersInputExtensionDto: GetIdentityUsersInput
    {
        public bool includeChildren { get; set; } = false;
    }
}
