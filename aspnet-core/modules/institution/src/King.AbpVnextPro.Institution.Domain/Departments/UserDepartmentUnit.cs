using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;
using Volo.Abp.MultiTenancy;

namespace King.AbpVnextPro.Institution.Departments
{
    public class UserDepartmentUnit : CreationAuditedEntity, IMultiTenant
    {
        /// <summary>
        /// Id of the User.
        /// </summary>
        public virtual Guid UserId { get; set; }
        /// <summary>
        /// Id of the related <see cref="DepartmentUnitId"/>.
        /// </summary>
        public virtual Guid DepartmentUnitId { get; set; }

        public virtual Guid? TenantId { get; set; }

        public UserDepartmentUnit()
        {

        }

        public UserDepartmentUnit(Guid userId, Guid departmentUnitId, Guid? tenantId = null)
        {
            UserId = userId;
            DepartmentUnitId = departmentUnitId;
            TenantId = tenantId;
        }

        public override object[] GetKeys()
        {
            return new object[] { UserId, DepartmentUnitId };
        }
    }
}
