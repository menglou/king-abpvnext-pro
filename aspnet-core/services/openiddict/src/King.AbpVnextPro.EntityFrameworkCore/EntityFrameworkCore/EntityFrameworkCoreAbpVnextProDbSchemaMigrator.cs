using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using King.AbpVnextPro.Data;
using Volo.Abp.DependencyInjection;

namespace King.AbpVnextPro.EntityFrameworkCore;

public class EntityFrameworkCoreAbpVnextProDbSchemaMigrator
    : IAbpVnextProDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpVnextProDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AbpVnextProDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpVnextProDbContext>()
            .Database
            .MigrateAsync();
    }
}
