using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.Institution.Departments
{
    public class BatchUserDepartmentUnitCreationDto : EntityDto
    {
        public BatchUserDepartmentUnitCreationDto()
        {
            UserId = new List<Guid>();
        }
        public List<Guid> UserId { get; set; }
        public Guid DepartmentUnitId { get; set; }
    }
}
