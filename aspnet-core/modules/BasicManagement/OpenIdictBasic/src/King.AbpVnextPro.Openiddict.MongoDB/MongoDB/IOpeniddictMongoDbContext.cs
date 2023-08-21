using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace King.AbpVnextPro.Openiddict.MongoDB;

[ConnectionStringName(OpeniddictDbProperties.ConnectionStringName)]
public interface IOpeniddictMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
