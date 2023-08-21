using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories;

namespace King.AbpVnextPro.ScheduleTask.Schedules
{
    public interface IScheduleHttpOptionEntityRepository:IRepository<ScheduleHttpOptionEntity,Guid>
    {
    }
}
