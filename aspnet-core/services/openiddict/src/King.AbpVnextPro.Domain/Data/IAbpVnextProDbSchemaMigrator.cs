using System.Threading.Tasks;

namespace King.AbpVnextPro.Data;

public interface IAbpVnextProDbSchemaMigrator
{
    Task MigrateAsync();
}
