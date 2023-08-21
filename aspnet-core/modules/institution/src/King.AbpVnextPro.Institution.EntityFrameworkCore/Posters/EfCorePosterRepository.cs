using King.AbpVnextPro.Institution.Departments;
using King.AbpVnextPro.Institution.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Identity;

namespace King.AbpVnextPro.Institution.Posters
{
    public class EfCorePosterRepository : EfCoreRepository<IInstitutionDbContext, Poster, Guid>,IPosterRepository
    {
        public EfCorePosterRepository(IDbContextProvider<IInstitutionDbContext> dbContextProvider): base(dbContextProvider)
        {

        }
    }
}
