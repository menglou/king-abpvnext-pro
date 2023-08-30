using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;
using Volo.Abp.Users;

namespace King.AbpVnextPro.ScheduleTask.Schedules
{
    public class ScheduleEntity : AuditedAggregateRoot<Guid>, IMultiTenant
    {
        /// <summary>
        /// 任务名称
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 任务分组
        /// </summary>
        public string JobGroup { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        public JobTypeEnum JobType { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 是否周期运行
        /// </summary>
       
        public bool RunLoop { get; set; }

        /// <summary>
        /// cron表达式
        /// </summary>
        public string CronExpression { get; set; }

        /// <summary>
        /// 任务所在程序集名称
        /// </summary>
        public string AssemblyName { get; set; }

        /// <summary>
        /// 执行类名称
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// 执行方法
        /// </summary>
        public string MethodName { get; set; }

        /// <summary>
        /// 文件存储名
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        public ScheduleStatus Status { get; set; }

        /// <summary>
        /// 生效日期
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// 失效日期
        /// </summary>
        public DateTime? EndDate { get; set; }


        /// <summary>
        /// 上次运行时间
        /// </summary>
        public DateTime? LastRunTime { get; set; }

        /// <summary>
        /// 下次运行时间
        /// </summary>
        public DateTime? NextRunTime { get; set; }

        /// <summary>
        /// 总运行成功次数
        /// </summary>
        public int TotalRunCount { get; set; }

        /// <summary>
        /// 是否有重试
        /// </summary>
        public bool IsHaveRetry { get; set; }

        /// <summary>
        /// 最大重试次数
        /// </summary>
        public int? MaxRetryCount { get; set; }

        /// <summary>
        /// 重试间隔 单位秒
        /// </summary>
        public int? RetryInterval { get; set; }

        /// <summary>
        /// 已经重试的次数
        /// </summary>
        public int? AlreadyRetryCount { get; set; }

        /// <summary>
        /// 是否同意发送邮件
        /// </summary>
        public bool IsAllowMail { get; set; }
        /// <summary>
        /// 是否同意发送短信
        /// </summary>
        public bool IsAllowSms { get; set; }
        /// <summary>
        /// 是否同意signarl
        /// </summary>
        public bool IsAllowSignarl { get; set; }

        public Guid? TenantId { get; set; }

        public ScheduleEntity()
        {

        }
        public ScheduleEntity(Guid id,
         string title ,
         string jobGroup ,
         JobTypeEnum jobType ,
         string remark ,
         bool runLoop ,
         string cronExpression ,
         string assemblyName ,
         string className ,
         ScheduleStatus status ,
         DateTime? startDate ,
         DateTime? endDate ,
         DateTime? lastRunTime ,
         DateTime? nextRunTime ,
         int totalRunCount ,
         bool isHaveRetry ,
         int? maxRetryCount ,
         int? retryInterval ,
         int? alreadyRetryCount ,
         bool isAllowMail,
         bool isAllowSms,
         bool isAllowSignarl,
         Guid? tenantId=null )
        {
            Id=id; 
            Title = title; 
            JobGroup = jobGroup; 
            JobType = jobType;
            Remark = remark;
            RunLoop = runLoop;
            CronExpression = cronExpression;
            AssemblyName = assemblyName;
            ClassName = className;
            Status = status;
            StartDate = startDate;
            EndDate = endDate;
            LastRunTime = lastRunTime;
            NextRunTime = nextRunTime;
            TotalRunCount = totalRunCount;
            IsHaveRetry = isHaveRetry;
            MaxRetryCount = maxRetryCount;
            RetryInterval = retryInterval;
            AlreadyRetryCount = alreadyRetryCount;
            IsAllowMail = isAllowMail;
            IsAllowSms = isAllowSms;
            IsAllowSignarl = isAllowSignarl;
            TenantId = tenantId;
        }
    }
}
