using Volo.Abp;
using Volo.Abp.MongoDB;

namespace King.AbpVnextPro.Openiddict.MongoDB;

public static class OpeniddictMongoDbContextExtensions
{
    public static void ConfigureOpeniddict(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
