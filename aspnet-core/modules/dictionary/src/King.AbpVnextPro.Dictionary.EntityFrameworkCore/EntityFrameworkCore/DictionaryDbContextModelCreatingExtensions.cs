using King.AbpVnextPro.Dictionary.DataDictionarys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace King.AbpVnextPro.Dictionary.EntityFrameworkCore;

public static class DictionaryDbContextModelCreatingExtensions
{
    public static void ConfigureDictionary(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(DictionaryDbProperties.DbTablePrefix + "Questions", DictionaryDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */

        builder.Entity<DataDictionary>(b =>
        {
            b.ToTable("DataDictionary", DictionaryDbProperties.DbSchema);
            b.ConfigureConcurrencyStamp();
            b.ConfigureExtraProperties();
            b.ConfigureAudited();
            b.Property(x => x.Name).IsRequired().HasMaxLength(DataDictionaryConsts.MaxNameLength);
            b.Property(x => x.Description).HasMaxLength(DataDictionaryConsts.MaxNotesLength);
            b.Property(x => x.Sort).HasDefaultValue(0);
            b.Property(x => x.IsDeleted).HasDefaultValue(false);

            b.HasIndex(q => q.Name);
        });

        builder.Entity<DataDictionaryDetail>(b =>
        {
            b.ToTable("DataDictionaryDetail", DictionaryDbProperties.DbSchema);
            b.ConfigureConcurrencyStamp();
            b.ConfigureExtraProperties();
            b.ConfigureAudited();
            b.Property(x => x.Label).IsRequired().HasMaxLength(DataDictionaryConsts.MaxNameLength);
            b.Property(x => x.Value).IsRequired().HasMaxLength(DataDictionaryConsts.MaxNotesLength);
            b.Property(x => x.Sort).HasDefaultValue(0);
            b.Property(x => x.IsDeleted).HasDefaultValue(false);

            b.HasIndex(q => q.DataDictionaryId);
        });
    }
}
