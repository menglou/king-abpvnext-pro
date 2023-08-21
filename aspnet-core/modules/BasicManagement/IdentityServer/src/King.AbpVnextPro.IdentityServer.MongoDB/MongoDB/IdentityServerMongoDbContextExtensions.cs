using Volo.Abp;
using Volo.Abp.MongoDB;

namespace King.AbpVnextPro.IdentityServer.MongoDB;

public static class IdentityServerMongoDbContextExtensions
{
    public static void ConfigureIdentityServer(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
