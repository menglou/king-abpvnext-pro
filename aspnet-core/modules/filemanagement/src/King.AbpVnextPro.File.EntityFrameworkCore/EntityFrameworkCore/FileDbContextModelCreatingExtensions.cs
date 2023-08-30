using King.AbpVnextPro.File.Filess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace King.AbpVnextPro.File.EntityFrameworkCore;

public static class FileDbContextModelCreatingExtensions
{
    public static void ConfigureFile(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(FileDbProperties.DbTablePrefix + "Questions", FileDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */

        builder.Entity<Files>(b =>
        {
            //Configure table & schema name
            b.ToTable("Files", FileDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.FileName).IsRequired().HasMaxLength(FileConsts.MaxFileNameLength);
            b.Property(q => q.BlobName).IsRequired().HasMaxLength(FileConsts.MaxBlobNameLength);
            b.Property(q => q.ByteSize).IsRequired();
        });
    }
}
