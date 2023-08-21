using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace King.AbpVnextPro.WorkFlow.Flows
{
    /// <summary>
    /// 流程实例
    /// </summary>
    public class FlowInstance:FullAuditedEntity<Guid>,IMultiTenant
    {
        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 自定义名称
        /// </summary>
        public string CustomName { get; set; } = string.Empty;
        /// <summary>
        /// 流程设计id
        /// </summary>
        public string DesignId { get; set; } = string.Empty;
        /// <summary>
        /// 流程类型
        /// </summary>
        public int DesignType { get; set; } = 0;
        public string DesignName { get; set; } = string.Empty;
        /// <summary>
        /// 当前节点id
        /// </summary>
        public string ActivityId { get; set; } = string.Empty;
        /// <summary>
        /// 当前节点类型 0 开始 1审核 2 抄送 3 条件 4路由(条件节点父级)
        /// </summary>
        public int ActivityType { get; set; } = 0;
        /// <summary>
        /// 当前节点名称
        /// </summary>
        public string ActivityName { get; set; } = string.Empty;
        /// <summary>
        /// 上一节点id
        /// </summary>
        public string PreviousId { get; set; } = string.Empty;
        /// <summary>
        /// 当前节点每个字段的是否显示是否可编辑 json 数组对象
        /// </summary>
        public string CurrColnumPermission { get; set; } = string.Empty;
        /// <summary>
        /// 设计内容
        /// </summary>
        public string DesignContent { get; set; } = string.Empty;
        /// <summary>
        /// 表单内容
        /// </summary>
        public string FormContent { get; set; } = string.Empty;
        /// <summary>
        /// 表单数据
        /// </summary>
        public string FormData { get; set; } = string.Empty;
        /// <summary>
        /// 单据id
        /// </summary>
        public string BillId { get; set; } = string.Empty;
        /// <summary>
        /// 审批人 多个逗号隔开
        /// </summary>
        public string MakerList { get; set; } = string.Empty;
        /// <summary>
        /// 抄送人 多个逗号隔开
        /// </summary>
        public string CcUsers { get; set; } = string.Empty;
        /// <summary>
        /// 节点集合 []
        /// </summary>
        public string Nodes { get; set; } = string.Empty;
        /// <summary>
        /// 打印设计内容
        /// </summary>
        public string PrintContent { get; set; } = string.Empty;
        /// <summary>
        /// 提交时间
        /// </summary>
        public DateTime? ApplyTime { get; set; }
        /// <summary>
        /// 状态 1草稿 2 流转中3 结束
        /// </summary>
        public int Status { get; set; } = 0;
        /// <summary>
        /// 结果 1运行中 2完成 3撤回 4不同意 5 退回
        /// </summary>
        public int InstanceResult { get; set; } = 0;

        public Guid ApplyUserId { get; set; }
        public Guid ApplyDepartId { get; set; }

        public Guid? TenantId { get; set; }
    }
}
