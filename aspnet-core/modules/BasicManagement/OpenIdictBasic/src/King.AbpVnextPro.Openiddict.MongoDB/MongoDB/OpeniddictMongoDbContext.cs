using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace King.AbpVnextPro.Openiddict.MongoDB;

[ConnectionStringName(OpeniddictDbProperties.ConnectionStringName)]
public class OpeniddictMongoDbContext : AbpMongoDbContext, IOpeniddictMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureOpeniddict();
    }
}
