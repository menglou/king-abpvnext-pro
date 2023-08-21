using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.Institution.Departments
{
    public class GetAllDepartmentUnitInput: ISortedResultRequest
    {
        public GetAllDepartmentUnitInput()
        {
            Sorting = "Code";
        }
        public string Filter { get; set; }
        public string Sorting { get; set; }
    }
}
