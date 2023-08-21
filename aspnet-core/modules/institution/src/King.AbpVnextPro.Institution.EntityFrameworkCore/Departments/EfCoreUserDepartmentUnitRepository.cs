using King.AbpVnextPro.Institution.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.Institution.Departments
{
    public class EfCoreUserDepartmentUnitRepository : EfCoreRepository<IInstitutionDbContext, UserDepartmentUnit>, IUserDepartmentUnitRepository
    {
        public EfCoreUserDepartmentUnitRepository(IDbContextProvider<IInstitutionDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
    }
}
