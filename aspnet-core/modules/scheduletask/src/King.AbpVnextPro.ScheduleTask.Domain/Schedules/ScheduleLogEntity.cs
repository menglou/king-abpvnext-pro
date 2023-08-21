using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace King.AbpVnextPro.ScheduleTask.Schedules
{
    public class ScheduleLogEntity : AuditedAggregateRoot<Guid>, IMultiTenant
    {
        /// <summary>
        /// 任务Id
        /// </summary>
        public Guid ScheduleId { get; set; }
        /// <summary>
        /// 任务名
        /// </summary>
        public string JobName { get; set; }
        /// <summary>
        /// 任务分组
        /// </summary>
        public string JobGroup { get; set; }
        /// <summary>
        /// 执行状态（0正常 1失败）
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// 异常
        /// </summary>
        public string Exception { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string JobMessage { get; set; }
        /// <summary>
        /// 调用目标字符串
        /// </summary>
        public string InvokeTarget { get; set; }
        /// <summary>
        /// 执行用时，毫秒
        /// </summary>
        public double Elapsed { get; set; }
        public Guid? TenantId { get; set; }
    }
}
