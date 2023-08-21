using King.AbpVnextPro.Institution.Departments;
using King.AbpVnextPro.Institution.Posters;
using King.AbpVnextPro.Institution.Users;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;

namespace King.AbpVnextPro.Institution.EntityFrameworkCore;

public static class InstitutionDbContextModelCreatingExtensions
{
    public static void ConfigureInstitution(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

      

        builder.Entity<DepartmentUnit>(b =>
        {
            b.ToTable("DepartmentUnits", InstitutionDbProperties.DbSchema);

            b.ConfigureByConvention();

            b.Property(ou => ou.Code).IsRequired().HasMaxLength(DepartmentUnitConsts.MaxCodeLength)

                .HasColumnName(nameof(DepartmentUnit.Code));

            b.Property(ou => ou.DisplayName).IsRequired().HasMaxLength(DepartmentUnitConsts.MaxDisplayNameLength)
                .HasColumnName(nameof(DepartmentUnit.DisplayName));

            b.HasMany<DepartmentUnit>().WithOne().HasForeignKey(ou => ou.ParentId);

            b.HasMany(x => x.UserDepartmentUnits).WithOne().HasForeignKey(ou => ou.DepartmentUnitId);

            b.HasIndex(ou => ou.Code);

            b.ApplyObjectExtensionMappings();
        });

        builder.Entity<UserDepartmentUnit>(b =>
        {
            b.ToTable("UserDepartmentUnits", InstitutionDbProperties.DbSchema);

            b.ConfigureByConvention();

            b.HasKey(ou => new {ou.UserId, ou.DepartmentUnitId });
          

            b.HasIndex(ou => new { ou.UserId, ou.DepartmentUnitId });

            b.ApplyObjectExtensionMappings();
        });


        builder.Entity<Poster>(b =>
        {
            b.ToTable("Posters", InstitutionDbProperties.DbSchema);
            b.ConfigureByConvention();
            b.Property(ou => ou.Code).IsRequired().HasMaxLength(100).HasColumnName(nameof(DepartmentUnit.Code));
            b.Property(ou => ou.Name).IsRequired().HasMaxLength(200).HasColumnName(nameof(Poster.Name));
            b.HasMany(ou => ou.UserPosters).WithOne().HasForeignKey(our => our.PotserId).IsRequired();
            b.HasIndex(ou => ou.Code);
            b.ApplyObjectExtensionMappings();
        });

        builder.Entity<UserPoster>(b =>
        {
            b.ToTable("UserPosters", InstitutionDbProperties.DbSchema);
            b.ConfigureByConvention();
            b.HasKey(ou => new { ou.PotserId, ou.UserId });
            b.HasIndex(ou => new { ou.PotserId, ou.UserId });
            b.ApplyObjectExtensionMappings();
        });

        builder.TryConfigureObjectExtensions<InstitutionDbContext>();
    }
}
