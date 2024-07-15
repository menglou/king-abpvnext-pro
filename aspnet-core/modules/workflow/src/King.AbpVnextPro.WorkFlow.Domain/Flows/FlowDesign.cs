using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace King.AbpVnextPro.WorkFlow.Flows
{
    /// <summary>
    /// 流程设计
    /// </summary>
    public class FlowDesign : FullAuditedEntity<Guid>, IMultiTenant
    {
        /// <summary>
        /// 流程模板名称
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 设计内容（审批流程设置得流程图）
        /// </summary>
        public string DesignContent { get; set; }
        /// <summary>
        /// 表单内容 (流程字段设置得东西，一些按钮，文本等)
        /// </summary>
        public string FormContent { get; set; } 
        /// <summary>
        /// 打印内容
        /// </summary>
        public string PrintContent { get; set; } 
        /// <summary>
        /// 使用权限(基础信息里面 流程适用得范围)
        /// </summary>
        public string Permission { get; set; }

        /// <summary>
        /// 申请时字段权限（流程字段设置得一些按钮，文本展示权限）
        /// </summary>
        public string ColnumPermission { get; set; } 
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnable { get; set; }
        public string Remark { get; set; } 
        public Guid? TenantId { get; set; }


        public FlowDesign(string name,string designContent, string formContent, string printContent, string permission, string colnumPermission, bool isEnable, string remark,Guid? tenantId=null)
        {
            Name = name;
            DesignContent = designContent;
            FormContent = formContent;
            PrintContent = printContent;
            Permission = permission;
            ColnumPermission = colnumPermission;
            IsEnable = isEnable;
            Remark = remark;
            TenantId = tenantId;
        }
    }
}
