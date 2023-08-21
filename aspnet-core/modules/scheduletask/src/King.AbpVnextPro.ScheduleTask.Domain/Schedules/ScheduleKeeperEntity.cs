using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace King.AbpVnextPro.ScheduleTask.Schedules
{
    public class ScheduleKeeperEntity : AuditedAggregateRoot<Guid>, IMultiTenant
    {
        public Guid ScheduleId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 发邮件用
        /// </summary>
        public string MailAddress { get; set; }

        /// <summary>
        /// 手机号--发短信用
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 微信openid
        /// </summary>
        public string WeChatId { get; set; }

        public Guid? TenantId { get; set; }
    }
}
