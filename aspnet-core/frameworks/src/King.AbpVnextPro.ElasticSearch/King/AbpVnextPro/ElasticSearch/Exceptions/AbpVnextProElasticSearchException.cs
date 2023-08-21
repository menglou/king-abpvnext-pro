

namespace King.AbpVnextPro.ElasticSearch.Exceptions;

public class AbpVnextProElasticSearchException : BusinessException
{
    public AbpVnextProElasticSearchException(
        string code = null,
        string message = null,
        string details = null,
        Exception innerException = null,
        LogLevel logLevel = LogLevel.Error)
        : base(
            code,
            message,
            details,
            innerException,
            logLevel
        )
    {
    }

    public AbpVnextProElasticSearchException(SerializationInfo serializationInfo, StreamingContext context) : base(serializationInfo, context)
    {
    }
}