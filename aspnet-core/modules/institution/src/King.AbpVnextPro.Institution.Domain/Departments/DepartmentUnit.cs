using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace King.AbpVnextPro.Institution.Departments
{
    public class DepartmentUnit : FullAuditedAggregateRoot<Guid>, IMultiTenant
    {
        public virtual Guid? ParentId { get; set; }
        public virtual string Code { get; set; }

        public virtual string DisplayName { get; set; }
        public virtual Guid? TenantId { get; set; }

        public virtual ICollection<UserDepartmentUnit> UserDepartmentUnits { get; set; }
        public DepartmentUnit()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentUnit"/> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="displayName">Display name.</param>
        /// <param name="parentId">Parent's Id or null if OU is a root.</param>
        /// <param name="tenantId">Tenant's Id or null for host.</param>
        public DepartmentUnit(Guid id, string displayName, Guid? parentId = null, Guid? tenantId = null)
            : base(id)
        {
            TenantId = tenantId;
            DisplayName = displayName;
            ParentId = parentId;
            UserDepartmentUnits=new Collection<UserDepartmentUnit>();
        }


        /// <summary>
        /// Creates code for given numbers.
        /// Example: if numbers are 4,2 then returns "00004.00002";
        /// </summary>
        /// <param name="numbers">Numbers</param>
        public static string CreateCode(params int[] numbers)
        {
            if (numbers.IsNullOrEmpty())
            {
                return null;
            }

            return numbers.Select(number => number.ToString(new string('0', DepartmentUnitConsts.CodeUnitLength))).JoinAsString(".");
        }

        /// <summary>
        /// Appends a child code to a parent code.
        /// Example: if parentCode = "00001", childCode = "00042" then returns "00001.00042".
        /// </summary>
        /// <param name="parentCode">Parent code. Can be null or empty if parent is a root.</param>
        /// <param name="childCode">Child code.</param>
        public static string AppendCode(string parentCode, string childCode)
        {
            if (childCode.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(childCode), "childCode can not be null or empty.");
            }

            if (parentCode.IsNullOrEmpty())
            {
                return childCode;
            }

            return parentCode + "." + childCode;
        }

        /// <summary>
        /// Gets relative code to the parent.
        /// Example: if code = "00019.00055.00001" and parentCode = "00019" then returns "00055.00001".
        /// </summary>
        /// <param name="code">The code.</param>
        /// <param name="parentCode">The parent code.</param>
        public static string GetRelativeCode(string code, string parentCode)
        {
            if (code.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(code), "code can not be null or empty.");
            }

            if (parentCode.IsNullOrEmpty())
            {
                return code;
            }

            if (code.Length == parentCode.Length)
            {
                return null;
            }

            return code.Substring(parentCode.Length + 1);
        }
    }
}
