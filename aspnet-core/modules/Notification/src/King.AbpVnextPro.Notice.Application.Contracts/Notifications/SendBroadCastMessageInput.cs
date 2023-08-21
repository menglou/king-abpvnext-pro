using King.AbpVnextPro.Notice.Localization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace King.AbpVnextPro.Notice.Notifications
{
    public class SendBroadCastMessageInput : IValidatableObject
    {
        /// <summary>
        /// 消息标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 消息状态
        /// </summary>
        public int Status { get; set; }

        public bool IsCreate { get; set; }

        public Guid? From { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var localization = validationContext.GetRequiredService<IStringLocalizer<NoticeResource>>();

            if (Title.IsNullOrWhiteSpace())
            {
                yield return new ValidationResult(localization[NoticeErrorCodes.MessageTitle], new[] { nameof(Title) });
            }
            if (Content.IsNullOrWhiteSpace())
            {
                yield return new ValidationResult(localization[NoticeErrorCodes.MessageContent], new[] { nameof(Content) });
            }
        }
    }
}
