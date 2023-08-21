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
        /// 模板类型 1 考勤管理 2 财务管理 3行政管理
        /// </summary>
        public int DesignType { get; set; }
        /// <summary>
        /// 设计内容
        /// </summary>
        public string DesignContent { get; set; } 
        /// <summary>
        /// 表单内容
        /// </summary>
        public string FormContent { get; set; } 
        /// <summary>
        /// 打印内容
        /// </summary>
        public string PrintContent { get; set; } 
        /// <summary>
        /// 使用权限
        /// </summary>
        public string Permission { get; set; } 

        /// <summary>
        /// 申请时字段权限
        /// </summary>
        public string ColnumPermission { get; set; } 
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnable { get; set; }
        public string Remark { get; set; } 
        public Guid? TenantId { get; set; }


        public FlowDesign(string name,int designType, string designContent, string formContent, string printContent, string permission, string colnumPermission, bool isEnable, string remark,Guid? tenantId=null)
        {
            Name = name;
            DesignType = designType;
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
