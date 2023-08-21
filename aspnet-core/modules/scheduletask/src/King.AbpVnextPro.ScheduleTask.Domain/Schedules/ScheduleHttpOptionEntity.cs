using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace King.AbpVnextPro.ScheduleTask.Schedules
{
    public class ScheduleHttpOptionEntity: AuditedAggregateRoot<Guid>,IMultiTenant
    {
        public Guid ScheduleId { get; set; }
        /// <summary>
        /// 请求地址
        /// </summary>
        public string RequestUrl { get; set; }

        /// <summary>
        /// 请求方式
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// 数据格式
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// 自定义请求头（json格式）
        /// </summary>
        public string Headers { get; set; }

        /// <summary>
        /// 数据内容（json格式）
        /// </summary>
        public string Body { get; set; }

        public Guid? TenantId { get; set; }
    }
}
