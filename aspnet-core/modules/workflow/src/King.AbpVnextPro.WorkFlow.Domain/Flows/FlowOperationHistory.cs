using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace King.AbpVnextPro.WorkFlow.Flows
{
    /// <summary>
    /// 流程操作记录
    /// </summary>
    public class FlowOperationHistory:FullAuditedEntity<Guid>,IMultiTenant
    {
        /// <summary>
        /// 实例id
        /// </summary>
        public Guid InstanceId { get; set; }
        /// <summary>
        /// 操作类型 1 发起 2审批 3撤回
        /// </summary>
        public OperationType OperationType { get; set; } = OperationType.Unknown;
        /// <summary>
        /// 1同意2不同意
        /// </summary>
        public Opinion Opinion { get; set; } = Opinion.Unknown;
        /// <summary>
        /// 签名
        /// </summary>
        public string Signature { get; set; } = string.Empty;
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; } = string.Empty;
        /// <summary>
        /// 操作内容 操作内容 由意见 备注 操作人 时间 整合
        /// </summary>
        public string Content { get; set; } = string.Empty;
        /// <summary>
        /// 节点类型  0 开始 1审核 
        /// </summary>
        public int NodeType { get; set; } = 0;
        /// <summary>
        /// 流程节点id
        /// </summary>
        public string NodeId { get; set; }
        /// <summary>
        /// 节点名称
        /// </summary>
        public string NodeName { get; set; } = string.Empty;
        /// <summary>
        /// 撤回/不同意 前面的记录都改为false
        /// </summary>
        public bool IsNewOperationt { get; set; } = false;
        /// <summary>
        /// 附件
        /// </summary>
        public string Attacth { get; set; }

        public Guid? TenantId { get; set; }
    }
}
