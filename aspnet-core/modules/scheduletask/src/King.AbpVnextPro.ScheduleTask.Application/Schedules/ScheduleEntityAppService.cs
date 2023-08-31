using King.AbpVnextPro.ScheduleTask.ScheduleMaster.Manager;
using Newtonsoft.Json;
using Org.BouncyCastle.Math.EC.Rfc7748;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Linq;
using Volo.Abp.MultiTenancy;

namespace King.AbpVnextPro.ScheduleTask.Schedules
{
    public class ScheduleEntityAppService : ScheduleTaskAppService, IScheduleEntityAppService
    {
        private readonly IAsyncQueryableExecuter _asyncExecuter;
        private IScheduleKeeperEntityRepository _scheduleKeeperEntityRepository;
        private IQuartzManager _quartzManager { get; set; }
        private IScheduleEntityRepository _scheduleEntityRepository { get; set; }
        private IScheduleHttpOptionEntityRepository _scheduleHttpOptionEntityRepository { get; set; }
        private IScheduleLogEntityRepository _scheduleLogEntityRepository { get; set; }
        public ScheduleEntityAppService(IQuartzManager quartzManager, IScheduleEntityRepository scheduleEntityRepository, IScheduleHttpOptionEntityRepository scheduleHttpOptionEntityRepository, IScheduleKeeperEntityRepository scheduleKeeperEntityRepository, IScheduleLogEntityRepository scheduleLogEntityRepository, IAsyncQueryableExecuter asyncExecuter)
        {
            _quartzManager = quartzManager;
            _scheduleEntityRepository = scheduleEntityRepository;
            _scheduleHttpOptionEntityRepository = scheduleHttpOptionEntityRepository;
            _scheduleKeeperEntityRepository = scheduleKeeperEntityRepository;
            _scheduleLogEntityRepository = scheduleLogEntityRepository;
            _asyncExecuter = asyncExecuter;
        }

        /// <summary>
        /// 创建任务
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public async Task<bool> CreateAsync(CreateScheduleInfoDto task)
        {

            Guid scheduleid = GuidGenerator.Create();
            ScheduleEntity main = new ScheduleEntity(scheduleid, task.Title, task.JobGroup, task.JobType, task.Remark, task.RunLoop, task.CronExpression, task.AssemblyName, task.ClassName, task.MethodName,task.FileName, ScheduleStatus.Stop, task.StartDate, task.EndDate, null, null, 0, task.IsHaveRetry, task.MaxRetryCount, task.RetryInterval, 0, task.IsAllowMail, task.IsAllowSms, task.IsAllowSignarl, CurrentTenant.Id);
            //程序集任务
            if (task.JobType == JobTypeEnum.Assembly)
            {
                main.AssemblyName = task.AssemblyName;
                main.ClassName = task.ClassName;
            }
            //http 任务
            ScheduleHttpOptionEntity httpOption = null;
            if (task.JobType == JobTypeEnum.Url)
            {
                httpOption = new ScheduleHttpOptionEntity
                {
                    ScheduleId = scheduleid,
                    RequestUrl = task.RequestUrl,
                    Method = task.Method,
                    ContentType = task.ContentType,
                    Headers = task.Headers,
                    Body = task.Body
                };
            }
            //监护人
            List<ScheduleKeeperEntity> scheduleKeeperEntitys = new List<ScheduleKeeperEntity>();
            if (task.KeeperInfo.Count > 0)
            {
                foreach (var item in task.KeeperInfo)
                {
                    ScheduleKeeperEntity scheduleKeeperEntity = new ScheduleKeeperEntity()
                    {
                        ScheduleId = scheduleid,
                        UserId = item.UserId,
                        UserName = item.UserName,
                        MailAddress = item.MailAddress,
                        PhoneNumber = item.PhoneNumber,
                        WeChatId = item.WeChatId,
                        TenantId = CurrentTenant.Id
                    };
                    scheduleKeeperEntitys.Add(scheduleKeeperEntity);
                }
            }
            //添加计划任务基础信息到数据库
            await _scheduleEntityRepository.InsertAsync(main);

            //如果执行http 任务
            if (httpOption != null)
            {
                await _scheduleHttpOptionEntityRepository.InsertAsync(httpOption);
            }

            await _scheduleKeeperEntityRepository.InsertManyAsync(scheduleKeeperEntitys);

            //如果创建并运行的话
            if (task.RunNow)
            {
                CurrentUnitOfWork.OnCompleted(new Func<Task>(async () =>
                {
                    ScheduleManagerDto ScheduleManagerDto = ObjectMapper.Map<CreateScheduleInfoDto, ScheduleManagerDto>(task);
                    ScheduleManagerDto.Id = scheduleid;
                    var res = await _quartzManager.AddTaskScheduleAsync(ScheduleManagerDto);
                    if (res != null)
                    {
                        //运行成功更新状态
                        main.Status = ScheduleStatus.Running;
                        //下次运行时间
                        main.NextRunTime = TimeZoneInfo.ConvertTimeFromUtc(res.GetNextFireTimeUtc().Value.UtcDateTime, TimeZoneInfo.Local);
                        await _scheduleEntityRepository.UpdateAsync(main);
                    }
                }));
            }
            return true;
        }

        /// <summary>
        /// 启动任务适合重来没有启动过的(启动一个全新的任务)
        /// </summary>
        /// <param name="sid"></param>
        /// <returns></returns>
        /// <exception cref="UserFriendlyException"></exception>
        public async Task<bool> StartAsync(Guid sid)
        {
            var tasksQz = await _scheduleEntityRepository.FindAsync(m => m.Id == sid);
            if (tasksQz == null)
            {
                throw new UserFriendlyException(L["Schedule:NotExits"]);
            }
            var keerps = (await _scheduleKeeperEntityRepository.GetQueryableAsync()).Where(x => x.ScheduleId == sid).Select(x => new KeepersInfo()
            {
                UserId = x.UserId,
                MailAddress = x.MailAddress,
                PhoneNumber = x.PhoneNumber,
                UserName = x.UserName,
                WeChatId = x.WeChatId,
            }).ToList();
            var httoption=await _scheduleHttpOptionEntityRepository.FindAsync(x=>x.ScheduleId == sid);

            ScheduleManagerDto createScheduleInfoDto = new ScheduleManagerDto()
            {
                Id = tasksQz.Id,
                Title = tasksQz.Title,
                JobGroup = tasksQz.JobGroup,
                JobType = tasksQz.JobType,
                CronExpression=tasksQz.CronExpression,
                RunLoop=tasksQz.RunLoop,
                AssemblyName=tasksQz.AssemblyName,
                ClassName=tasksQz.ClassName,
                MethodName=tasksQz.MethodName,
                FileName=tasksQz.FileName,
                StartDate = tasksQz.StartDate,
                EndDate = tasksQz.EndDate,
                IsHaveRetry=tasksQz.IsHaveRetry,
                RetryInterval=tasksQz.RetryInterval,
                MaxRetryCount=tasksQz.MaxRetryCount,
                IsAllowMail=tasksQz.IsAllowMail,
                IsAllowSignarl=tasksQz.IsAllowSignarl,
                IsAllowSms=tasksQz.IsAllowSms,
                RequestUrl= tasksQz.JobType==JobTypeEnum.Url? httoption.RequestUrl: string.Empty,
                Method= tasksQz.JobType == JobTypeEnum.Url ? httoption.Method : string.Empty,
                ContentType= tasksQz.JobType == JobTypeEnum.Url ? httoption.ContentType : string.Empty,
                Headers= tasksQz.JobType == JobTypeEnum.Url ? httoption.Headers : string.Empty,
                Body= tasksQz.JobType == JobTypeEnum.Url ? httoption.Body : string.Empty,
                KeeperInfo = keerps
            };
            var taskResult = await _quartzManager.AddTaskScheduleAsync(createScheduleInfoDto);
            if (taskResult != null)
            {
                //更新状态
                tasksQz.Status = ScheduleStatus.Running;
                await _scheduleEntityRepository.UpdateAsync(tasksQz);
            }
            return true;
        }
        /// <summary>
        /// 停止任务
        /// </summary>
        /// <param name="sid"></param>
        /// <returns></returns>
        /// <exception cref="UserFriendlyException"></exception>
        public async Task<bool> StopAsync(Guid sid)
        {
            var tasksQz = await _scheduleEntityRepository.FindAsync(m => m.Id == sid);
            if (tasksQz == null)
            {
                throw new UserFriendlyException(L["Schedule:NotExits"]);
            }
            ScheduleManagerDto createScheduleInfoDto = new ScheduleManagerDto()
            {
                Id = tasksQz.Id,
                JobGroup = tasksQz.JobGroup
            };
            var taskResult = await _quartzManager.StopTaskScheduleAsync(createScheduleInfoDto);
            if (taskResult == true)
            {
                tasksQz.Status = ScheduleStatus.Stop;
                tasksQz.NextRunTime = null;
                await _scheduleEntityRepository.UpdateAsync(tasksQz);
            }
            return true;
        }

        /// <summary>
        /// 暂停一个任务
        /// </summary>
        /// <param name="sid"></param>
        /// <returns></returns>
        /// <exception cref="UserFriendlyException"></exception>
        public async Task<bool> PauseAsync(Guid sid)
        {
            var tasksQz = await _scheduleEntityRepository.FindAsync(m => m.Id == sid);
            if (tasksQz == null)
            {
                throw new UserFriendlyException(L["Schedule:NotExits"]);
            }
            ScheduleManagerDto createScheduleInfoDto = new ScheduleManagerDto()
            {
                Id = tasksQz.Id,
                JobGroup = tasksQz.JobGroup
            };
            var taskResult = await _quartzManager.PauseTaskScheduleAsync(createScheduleInfoDto);
            if (taskResult == true)
            {
                tasksQz.Status = ScheduleStatus.Paused;
                tasksQz.NextRunTime = null;
                await _scheduleEntityRepository.UpdateAsync(tasksQz);
            }
            return true;
        }


        /// <summary>
        /// 恢复一个任务任务
        /// </summary>
        /// <param name="sid"></param>
        /// <returns></returns>
        /// <exception cref="UserFriendlyException"></exception>
        public async Task<bool> ResumeAsync(Guid sid)
        {
            var tasksQz = await _scheduleEntityRepository.FindAsync(m => m.Id == sid);
            if (tasksQz == null)
            {
                throw new UserFriendlyException(L["Schedule:NotExits"]);
            }
            ScheduleManagerDto createScheduleInfoDto = new ScheduleManagerDto()
            {
                Id = tasksQz.Id,
                JobGroup = tasksQz.JobGroup
            };
            var taskResult = await _quartzManager.ResumeTaskScheduleAsync(createScheduleInfoDto);
            if (taskResult == true)
            {
                tasksQz.Status = ScheduleStatus.Running;
                await _scheduleEntityRepository.UpdateAsync(tasksQz);
            }
            return true;
        }

        /// <summary>
        /// 删除计划任务
        /// </summary>
        /// <param name="sid"></param>
        /// <returns></returns>
        /// <exception cref="UserFriendlyException"></exception>
        public async Task<bool> DeleteAsync(Guid sid)
        {
            var tasksQz = await _scheduleEntityRepository.FindAsync(m => m.Id == sid);
            if (tasksQz == null)
            {
                throw new UserFriendlyException(L["Schedule:NotExits"]);
            }
            //删除相关的东西 日志 ，http 参数  keepers
            var httpoptions = (await _scheduleHttpOptionEntityRepository.GetQueryableAsync()).Where(x => x.ScheduleId == tasksQz.Id).ToList();
            var keepers = (await _scheduleKeeperEntityRepository.GetQueryableAsync()).Where(x => x.ScheduleId == tasksQz.Id).ToList();
            var logs = (await _scheduleLogEntityRepository.GetQueryableAsync()).Where(x => x.ScheduleId == tasksQz.Id).ToList();

            await _scheduleEntityRepository.DeleteAsync(tasksQz);
            await _scheduleHttpOptionEntityRepository.DeleteManyAsync(httpoptions);
            await _scheduleKeeperEntityRepository.DeleteManyAsync(keepers);
            await _scheduleLogEntityRepository.DeleteManyAsync(logs);

            return true;
        }

        /// <summary>
        /// 定时任务立即执行一次
        /// </summary>
        /// <param name="sid"></param>
        /// <returns></returns>
        public async Task<bool> RunOnceAsync(Guid sid)
        {
            var tasksQz = await _scheduleEntityRepository.FindAsync(m => m.Id == sid);
            if (tasksQz == null)
            {
                throw new UserFriendlyException(L["Schedule:NotExits"]);
            }
            ScheduleManagerDto createScheduleInfoDto = new ScheduleManagerDto()
            {
                Id = tasksQz.Id,
                JobGroup = tasksQz.JobGroup
            };
            var taskResult = await _quartzManager.RunTaskScheduleAsync(createScheduleInfoDto);

            return taskResult;
        }


        /// <summary>
        /// 查询计划任务列表
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<PagedResultDto<ScheduleEntityDto>> GetListAsync(ScheduleTaskPagedListDto input)
        {
            //获取当天登录人 获取所有的任务
            var currentuserallkeepers = (await _scheduleKeeperEntityRepository.GetQueryableAsync()).Where(x => x.UserId == CurrentUser.Id).Select(x => x.ScheduleId);

            var query = from schedule in await _scheduleEntityRepository.GetListAsync()
                        join schedulehttpoption in await _scheduleHttpOptionEntityRepository.GetListAsync()
                        on schedule.Id equals schedulehttpoption.ScheduleId into scheduleList
                        from schedulehttpoption in scheduleList.DefaultIfEmpty()
                        where currentuserallkeepers.Contains(schedule.Id)
                        select new ScheduleEntityDto
                        {
                            Id = schedule.Id,
                            Title = schedule.Title,
                            JobGroup = schedule.JobGroup,
                            JobType = schedule.JobType,
                            Remark = schedule.Remark,
                            RunLoop = schedule.RunLoop,
                            CronExpression = schedule.CronExpression,
                            AssemblyName = schedule.AssemblyName,
                            ClassName = schedule.ClassName,
                            MethodName = schedule.MethodName,
                            FileName = schedule.FileName,
                            Status = schedule.Status,
                            StartDate = schedule.StartDate,
                            EndDate = schedule.EndDate,
                            LastRunTime = schedule.LastRunTime,
                            NextRunTime = schedule.NextRunTime,
                            TotalRunCount = schedule.TotalRunCount,
                            IsHaveRetry = schedule.IsHaveRetry,
                            MaxRetryCount = schedule.MaxRetryCount,
                            RetryInterval = schedule.RetryInterval,
                            AlreadyRetryCount = schedule.AlreadyRetryCount,
                            RequestUrl = schedulehttpoption == null ? "" : schedulehttpoption.RequestUrl,
                            Method = schedulehttpoption == null ? "" : schedulehttpoption.Method,
                            ContentType = schedulehttpoption == null ? "" : schedulehttpoption.ContentType,
                            Headers = schedulehttpoption == null ? "" : schedulehttpoption.Headers,
                            Body = schedulehttpoption == null ? "" : schedulehttpoption.Body
                        };

            var count = await _asyncExecuter.CountAsync(query.WhereIf(!input.JobName.IsNullOrWhiteSpace(), x => x.Title.Contains(input.JobName)).AsQueryable());

            var list = await _asyncExecuter.ToListAsync(query.WhereIf(!input.JobName.IsNullOrWhiteSpace(), x => x.Title.Contains(input.JobName)).AsQueryable().PageBy(input.SkipCount, input.MaxResultCount));

            return new PagedResultDto<ScheduleEntityDto>(count, list);
        }

        /// <summary>
        /// 查询计划任务详情
        /// </summary>
        /// <param name="sid"></param>
        /// <returns></returns>
        public async Task<ScheduleEntityDto> GetAsync(Guid sid)
        {

            var query = (from schedule in await _scheduleEntityRepository.GetListAsync()
                         join schedulehttpoption in await _scheduleHttpOptionEntityRepository.GetListAsync()
                         on schedule.Id equals schedulehttpoption.ScheduleId into scheduleList
                         from schedulehttpoption in scheduleList.DefaultIfEmpty()
                         where schedule.Id == sid
                         select new ScheduleEntityDto
                         {
                             Id = schedule.Id,
                             Title = schedule.Title,
                             JobGroup = schedule.JobGroup,
                             JobType = schedule.JobType,
                             Remark = schedule.Remark,
                             RunLoop = schedule.RunLoop,
                             CronExpression = schedule.CronExpression,
                             AssemblyName = schedule.AssemblyName,
                             ClassName = schedule.ClassName,
                             MethodName = schedule.MethodName,
                             FileName = schedule.FileName,
                             Status = schedule.Status,
                             StartDate = schedule.StartDate,
                             EndDate = schedule.EndDate,
                             LastRunTime = schedule.LastRunTime,
                             NextRunTime = schedule.NextRunTime,
                             TotalRunCount = schedule.TotalRunCount,
                             IsHaveRetry = schedule.IsHaveRetry,
                             MaxRetryCount = schedule.MaxRetryCount,
                             RetryInterval = schedule.RetryInterval,
                             AlreadyRetryCount = schedule.AlreadyRetryCount,
                             RequestUrl = schedulehttpoption == null ? "" : schedulehttpoption.RequestUrl,
                             Method = schedulehttpoption == null ? "" : schedulehttpoption.Method,
                             ContentType = schedulehttpoption == null ? "" : schedulehttpoption.ContentType,
                             Headers = schedulehttpoption == null ? "" : schedulehttpoption.Headers,
                             Body = schedulehttpoption == null ? "" : schedulehttpoption.Body,
                             IsAllowMail = schedule.IsAllowMail,
                             IsAllowSms = schedule.IsAllowSms,
                             IsAllowSignarl = schedule.IsAllowSignarl
                         }).FirstOrDefault();
            if (query != null)
            {
                var keepers = (await _scheduleKeeperEntityRepository.GetQueryableAsync()).Where(x => x.ScheduleId == query.Id).Select(x => new KeepersInfo()
                {
                    UserId = x.UserId,
                    UserName = x.UserName,
                    MailAddress = x.MailAddress,
                    PhoneNumber = x.PhoneNumber,
                    WeChatId = x.WeChatId,
                }).ToList();
                query.KeeperInfo.AddRange(keepers);
            }
            return query;
        }

        /// <summary>
        /// 编辑任务
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(UpdateScheduleInfoDto input)
        {
            ScheduleEntity schedule = await _scheduleEntityRepository.FindAsync(x => x.Id == input.Id);
            ScheduleEntity restmp = new ScheduleEntity();
            if (schedule != null)
            {
                if (schedule.Title != input.Title)
                {
                    restmp = await _scheduleEntityRepository.FindAsync(x => x.Title == input.Title);
                    if (restmp != null)
                    {
                        throw new UserFriendlyException($"待更新的任务{input.Title}已存在不能更新！");
                    }
                }
                //task.IsHaveRetry, task.MaxRetryCount, task.RetryInterval, 0, task.IsAllowMail, task.IsAllowSms, task.IsAllowSignarl, CurrentTenant.Id
                if (schedule.Title == input.Title || restmp == null)
                {
                    schedule.Title = input.Title;
                    schedule.JobGroup = input.JobGroup;
                    schedule.JobType = input.JobType;
                    schedule.Remark = input.Remark;
                    schedule.RunLoop = input.RunLoop;
                    schedule.CronExpression = input.CronExpression;
                    schedule.AssemblyName = input.AssemblyName;
                    schedule.ClassName = input.ClassName;
                    schedule.MethodName = input.MethodName;
                    schedule.FileName= input.FileName;
                    schedule.StartDate = input.StartDate;
                    schedule.EndDate = input.EndDate;
                    schedule.IsHaveRetry = input.IsHaveRetry;
                    schedule.MaxRetryCount = input.MaxRetryCount;
                    schedule.RetryInterval = input.RetryInterval;
                    schedule.IsAllowMail = input.IsAllowMail;
                    schedule.IsAllowSms = input.IsAllowSms;
                    schedule.IsAllowSignarl = input.IsAllowSignarl;
                    schedule.TenantId = CurrentTenant.Id;



                    var res = await _scheduleEntityRepository.UpdateAsync(schedule);

                    //http 任务
                    ScheduleHttpOptionEntity httpOption = await _scheduleHttpOptionEntityRepository.FindAsync(x => x.ScheduleId == input.Id);
                    if (httpOption != null)
                    {
                        if (input.JobType == JobTypeEnum.Url)
                        {
                            httpOption.RequestUrl = input.RequestUrl;
                            httpOption.Method = input.Method;
                            httpOption.ContentType = input.ContentType;
                            httpOption.Headers = input.Headers;
                            httpOption.Body = input.Body;
                            await _scheduleHttpOptionEntityRepository.UpdateAsync(httpOption);
                        }
                    }

                    //监护人

                    List<ScheduleKeeperEntity> scheduleKeeperEntitys = new List<ScheduleKeeperEntity>();
                    if (input.KeeperInfo.Count > 0)
                    {
                        var keepers = (await _scheduleKeeperEntityRepository.GetQueryableAsync()).Where(x => x.ScheduleId == input.Id).ToList();
                        await _scheduleKeeperEntityRepository.DeleteManyAsync(keepers);
                        foreach (var item in input.KeeperInfo)
                        {
                            ScheduleKeeperEntity scheduleKeeperEntity = new ScheduleKeeperEntity()
                            {
                                ScheduleId = input.Id,
                                UserId = item.UserId,
                                UserName = item.UserName,
                                MailAddress = item.MailAddress,
                                PhoneNumber = item.PhoneNumber,
                                WeChatId = item.WeChatId,
                                TenantId = CurrentTenant.Id
                            };
                            scheduleKeeperEntitys.Add(scheduleKeeperEntity);
                        }
                    }


                    await _scheduleKeeperEntityRepository.InsertManyAsync(scheduleKeeperEntitys);



                }

            }

            return true;
        }

        public async Task<List<ScheduleManagerDto>> GetListAllAsync(GetScheduleTaskListDto input)
        {
            var query = from schedule in await _scheduleEntityRepository.GetListAsync()
                        join schedulehttpoption in await _scheduleHttpOptionEntityRepository.GetListAsync()
                        on schedule.Id equals schedulehttpoption.ScheduleId
                        select new ScheduleManagerDto
                        {
                            Id = schedule.Id,
                            Title = schedule.Title,
                            JobGroup = schedule.JobGroup,
                            JobType = schedule.JobType,
                            Remark = schedule.Remark,
                            RunLoop = schedule.RunLoop,
                            CronExpression = schedule.CronExpression,
                            AssemblyName = schedule.AssemblyName,
                            ClassName = schedule.ClassName,
                            Status = schedule.Status,
                            StartDate = schedule.StartDate,
                            EndDate = schedule.EndDate,
                            IsHaveRetry = schedule.IsHaveRetry,
                            MaxRetryCount = schedule.MaxRetryCount,
                            RetryInterval = schedule.RetryInterval,
                            RequestUrl = schedulehttpoption.RequestUrl,
                            Method = schedulehttpoption.Method,
                            ContentType = schedulehttpoption.ContentType,
                            Headers = schedulehttpoption.Headers,
                            Body = schedulehttpoption.Body
                        };

            var list = await _asyncExecuter.ToListAsync(query.WhereIf(!input.JobName.IsNullOrWhiteSpace(), x => x.Title.Contains(input.JobName)).WhereIf(input.ScheduleStatus.HasValue, x => x.Status == input.ScheduleStatus).AsQueryable());

            foreach (var item in list)
            {
                var keepers = (await _scheduleKeeperEntityRepository.GetQueryableAsync()).Where(x => x.ScheduleId == item.Id).Select(x => new KeepersInfo()
                {
                    UserId = x.UserId,
                    UserName = x.UserName,
                    MailAddress = x.MailAddress,
                    PhoneNumber = x.PhoneNumber,
                    WeChatId = x.WeChatId,
                }).ToList();
                item.KeeperInfo.AddRange(keepers);
            }
            return list;
        }
    
        /// <summary>
        /// 分页查询任务日志
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<PagedResultDto<ScheduleLogEntityDto>> GetScheduleLogListAsync(ScheduleLogPagedListDto input)
        {
            var logs = (await _scheduleLogEntityRepository.GetQueryableAsync())
                .WhereIf(!input.Status.IsNullOrWhiteSpace(), x => x.Status.Contains(input.Status))
                .WhereIf(input.StartTime != null, x => x.CreationTime >= input.StartTime)
                .WhereIf(input.EndTime != null, x => x.CreationTime <= input.EndTime)
                .Where(x => x.ScheduleId == input.ScheduleId)
                .OrderByDescending(x=> x.CreationTime)
                .Skip(input.SkipCount).Take(input.MaxResultCount).ToList();

            var count = (await _scheduleLogEntityRepository.GetQueryableAsync())
                .WhereIf(!input.Status.IsNullOrWhiteSpace(), x => x.Status.Contains(input.Status))
                .WhereIf(input.StartTime != null, x => x.CreationTime >= input.StartTime)
                .WhereIf(input.EndTime != null, x => x.CreationTime <= input.EndTime)
                .Where(x => x.ScheduleId == input.ScheduleId).Count();


            return new PagedResultDto<ScheduleLogEntityDto>(count, ObjectMapper.Map<List<ScheduleLogEntity>, List<ScheduleLogEntityDto>>(logs));
        }


    }
}
