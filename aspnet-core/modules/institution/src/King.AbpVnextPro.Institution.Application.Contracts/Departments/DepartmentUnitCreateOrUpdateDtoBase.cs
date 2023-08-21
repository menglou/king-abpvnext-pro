using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Validation;

namespace King.AbpVnextPro.Institution.Departments
{
    public class DepartmentUnitCreateOrUpdateDtoBase: ExtensibleObject
    {
        [DynamicStringLength(typeof(DepartmentUnitConsts), nameof(DepartmentUnitConsts.MaxDisplayNameLength))]
        public string DisplayName { get; set; }

        protected DepartmentUnitCreateOrUpdateDtoBase() : base(false)
        {

        }
    }
}
