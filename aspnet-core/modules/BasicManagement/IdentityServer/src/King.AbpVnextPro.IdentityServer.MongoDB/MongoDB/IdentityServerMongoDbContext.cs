using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace King.AbpVnextPro.IdentityServer.MongoDB;

[ConnectionStringName(IdentityServerDbProperties.ConnectionStringName)]
public class IdentityServerMongoDbContext : AbpMongoDbContext, IIdentityServerMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureIdentityServer();
    }
}
