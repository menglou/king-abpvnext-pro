using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.IdentityServer.EntityFrameworkCore;

[ConnectionStringName(IdentityServerDbProperties.ConnectionStringName)]
public interface IIdentityServerDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
