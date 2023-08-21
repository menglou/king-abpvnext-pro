using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace King.AbpVnextPro.WorkFlow.Flows
{
    public class FlowNodes:FullAuditedEntity<Guid>,IMultiTenant
    {
        /// <summary>
        /// 实例id
        /// </summary>
        public Guid InstanceId { get; set; }

        public int NodeType { get; set; } = 0;
        /// <summary>
        /// 流程节点id
        /// </summary>
        public string NodeId { get; set; }
        /// <summary>
        /// 节点名称
        /// </summary>
        public string NodeName { get; set; } = string.Empty;

        public int Sort { get; set; }

        /// <summary>
        /// 审批人  多个,隔开
        /// </summary>
        public string Markers { get; set; }
        public string MarkerUserIds { get; set; }


        /// <summary>
        /// 当前节点每个字段的是否显示是否可编辑 json 数组对象
        /// </summary>
        public string CurrColnumPermission { get; set; } = string.Empty;

        public Guid? TenantId { get; set; }
    }
}
