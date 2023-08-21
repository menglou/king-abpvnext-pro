using King.AbpVnextPro.Institution.Departments;
using King.AbpVnextPro.Institution.Posters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Identity;

namespace King.AbpVnextPro.Institution.EntityFrameworkCore
{
    public static class InstitutionEfCoreQueryableExtensions
    {
        public static IQueryable<IdentityUser> IncludeDetails(this IQueryable<IdentityUser> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable
                .Include(x => x.OrganizationUnits);
        }

        public static IQueryable<DepartmentUnit> IncludeDetails(this IQueryable<DepartmentUnit> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable
                .Include(x => x.UserDepartmentUnits);
        }

    }
}
