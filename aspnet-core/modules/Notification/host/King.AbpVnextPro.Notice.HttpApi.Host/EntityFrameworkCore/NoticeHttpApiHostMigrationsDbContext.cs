using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.Notice.EntityFrameworkCore;

public class NoticeHttpApiHostMigrationsDbContext : AbpDbContext<NoticeHttpApiHostMigrationsDbContext>
{
    public NoticeHttpApiHostMigrationsDbContext(DbContextOptions<NoticeHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureNotice();
    }
}
