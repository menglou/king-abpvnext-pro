using King.AbpVnextPro.ScheduleTask.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.ScheduleTask.Schedules
{
    public class EfCoreScheduleHttpOptionEntityRepository : EfCoreRepository<IScheduleTaskDbContext, ScheduleHttpOptionEntity,Guid>, IScheduleHttpOptionEntityRepository
    {
        public EfCoreScheduleHttpOptionEntityRepository(IDbContextProvider<IScheduleTaskDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
    }
}
