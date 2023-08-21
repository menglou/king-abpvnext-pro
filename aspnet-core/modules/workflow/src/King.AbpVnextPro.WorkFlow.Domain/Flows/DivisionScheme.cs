using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace King.AbpVnextPro.WorkFlow.Flows
{
    /// <summary>
    /// 条件分工方案
    /// </summary>
    public class DivisionScheme : FullAuditedEntity<Guid>, IMultiTenant
    {
        /// <summary>
        /// 方案名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 多单位时使用
        /// </summary>
        public string UnitId { get; set; }

        /// <summary>
        /// 方案条件
        /// </summary>
        public string Condition { get; set; }
        public Guid? TenantId { get; set; }

        public DivisionScheme() { }

        public DivisionScheme(string name, string unitId, string condition, Guid? tenantId=null)
        {
            Name = name;
            UnitId = unitId;
            Condition = condition;
            TenantId = tenantId;
        }
    }
}
