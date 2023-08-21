using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.File.EntityFrameworkCore;

public class FileHttpApiHostMigrationsDbContext : AbpDbContext<FileHttpApiHostMigrationsDbContext>
{
    public FileHttpApiHostMigrationsDbContext(DbContextOptions<FileHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureFile();
    }
}
