using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.WorkFlow.Flows.DivisionSchemes
{
    public class DivisionSchemeCreationDto:EntityDto
    {
        public string Name { get; set; }

        [Required(ErrorMessage = "分工方案必填")]
        public string Condition { get; set; }
    }
}
