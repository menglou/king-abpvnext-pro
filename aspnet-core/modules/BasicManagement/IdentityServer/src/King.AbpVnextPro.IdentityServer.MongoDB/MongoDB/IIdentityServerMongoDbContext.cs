using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace King.AbpVnextPro.IdentityServer.MongoDB;

[ConnectionStringName(IdentityServerDbProperties.ConnectionStringName)]
public interface IIdentityServerMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
