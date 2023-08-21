using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.WorkFlow.Flows.DivisionSchemes
{
    public class DivisionSchemeDto:FullAuditedEntityDto<Guid>
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
    }
}
