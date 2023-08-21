using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Volo.Abp;

namespace King.AbpVnextPro.Notice
{
    public class NotificationDomainException : BusinessException
    {
        public NotificationDomainException(string code = null, string message = null, string details = null, Exception innerException = null,
            LogLevel logLevel = LogLevel.Warning) : base(code, message, details,
            innerException,
            logLevel
        )
        {
        }

        public NotificationDomainException(SerializationInfo serializationInfo, StreamingContext context) : base(serializationInfo, context)
        {
        }
    }
}
