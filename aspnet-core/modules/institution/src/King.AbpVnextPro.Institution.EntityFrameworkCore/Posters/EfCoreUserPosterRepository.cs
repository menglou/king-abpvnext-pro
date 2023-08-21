using King.AbpVnextPro.Institution.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.Institution.Posters
{
    public class EfCoreUserPosterRepository : EfCoreRepository<IInstitutionDbContext, UserPoster>, IUserPosterRepository
    {
        public EfCoreUserPosterRepository(IDbContextProvider<IInstitutionDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
    }
}
