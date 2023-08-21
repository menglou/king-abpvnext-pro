using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace King.AbpVnextPro.WorkFlow.Flows
{
    public enum OperationType
    {
        /// <summary>
        /// 未知
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// 发起申请
        /// </summary>
        [Description("发起申请")]
        Apply = 1,
        /// <summary>
        /// 审批
        /// </summary>
        [Description("审批")]
        Audit = 2,

        /// <summary>
        /// 撤回
        /// </summary>
        [Description("撤回")]
        Revocation = 3,
        /// <summary>
        /// 退回
        /// </summary>
        [Description("退回")]
        Back = 4,

        /// <summary>
        /// 加签
        /// </summary>
        [Description("加签")]
        Apostille = 8,
        /// <summary>
        /// 转交审批
        /// </summary>
        [Description("转交审批")]
        SendAudit = 9
    }
}
