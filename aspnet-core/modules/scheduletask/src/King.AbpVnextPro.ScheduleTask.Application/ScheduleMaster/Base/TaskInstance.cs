using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King.AbpVnextPro.ScheduleTask.ScheduleMaster.Base
{
    public class TaskInstance
    {
        public object Instance { get; set; }

        public Type Type { get; set; }
    }
}
