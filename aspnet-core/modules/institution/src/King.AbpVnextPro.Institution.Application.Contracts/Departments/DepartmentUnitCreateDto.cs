using System;
using System.Collections.Generic;
using System.Text;

namespace King.AbpVnextPro.Institution.Departments
{
    public class DepartmentUnitCreateDto: DepartmentUnitCreateOrUpdateDtoBase
    {
        public Guid? ParentId { get; set; }
    }
}
