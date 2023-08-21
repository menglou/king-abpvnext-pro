

namespace King.AbpVnextPro.ElasticSearch.Exceptions;

public class AbpVnextProElasticSearchEntityNotFoundException : BusinessException
{
    public AbpVnextProElasticSearchEntityNotFoundException(
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

    public AbpVnextProElasticSearchEntityNotFoundException(SerializationInfo serializationInfo, StreamingContext context) : base(serializationInfo, context)
    {
    }
}