using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace King.AbpVnextPro.Data;

/* This is used if database provider does't define
 * IAbpVnextProDbSchemaMigrator implementation.
 */
public class NullAbpVnextProDbSchemaMigrator : IAbpVnextProDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
