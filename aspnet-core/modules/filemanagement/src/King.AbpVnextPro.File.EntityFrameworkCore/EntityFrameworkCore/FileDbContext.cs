﻿using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using King.AbpVnextPro.File.Filess;

namespace King.AbpVnextPro.File.EntityFrameworkCore;

[ConnectionStringName(FileDbProperties.ConnectionStringName)]
public class FileDbContext : AbpDbContext<FileDbContext>, IFileDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public FileDbContext(DbContextOptions<FileDbContext> options)
        : base(options)
    {

    }

    public virtual DbSet<Files> Files { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureFile();
    }
}
