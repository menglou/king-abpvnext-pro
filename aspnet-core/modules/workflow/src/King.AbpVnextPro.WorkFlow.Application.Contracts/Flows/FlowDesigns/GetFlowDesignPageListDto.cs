using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.WorkFlow.Flows.FlowDesigns
{
    public class GetFlowDesignPageListDto : PagedAndSortedResultRequestDto
    {
        public string Name { get; set; }
        /// <summary>
        /// 是否已停用单据
        /// </summary>
        public bool? IsEnable { get; set; }
    }
}
