using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace King.AbpVnextPro.WorkFlow.Flows
{
    /// <summary>
    /// 抄送
    /// </summary>
    public class FlowCarbonCopy : FullAuditedEntity<Guid>, IMultiTenant
    {
        /// <summary>
        /// 实例id
        /// </summary>
        public Guid InstanceId { get; set; }

        /// <summary>
        /// 抄送人
        /// </summary>
        public Guid UserId { get; set; }

        //public string UnitId { get; set; }
        /// <summary>
        /// 抄送节点
        /// </summary>
        public Guid CcNodeId { get; set; }

        public bool IsRead { get; set; } = false;
        public Guid? TenantId { get; set; }
    }
}
