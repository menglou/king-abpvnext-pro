﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.WorkFlow.Flows.FlowDesigns
{
    public class FlowDesignDto : FullAuditedEntityDto<Guid>
    {
        /// <summary>
        /// 流程模板名称
        /// </summary>
        public string Name { get; set; }
       
        /// <summary>
        /// 设计内容
        /// </summary>
        public string DesignContent { get; set; }
        /// <summary>
        /// 表单内容
        /// </summary>
        public string FormContent { get; set; }
        /// <summary>
        /// 打印内容
        /// </summary>
        public string PrintContent { get; set; }
        /// <summary>
        /// 使用权限
        /// </summary>
        public string Permission { get; set; }

        /// <summary>
        /// 申请时字段权限
        /// </summary>
        public string ColnumPermission { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnable { get; set; }
        public string Remark { get; set; }
    }
}
