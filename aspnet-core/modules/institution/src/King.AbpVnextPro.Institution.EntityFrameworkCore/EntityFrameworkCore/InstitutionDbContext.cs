using King.AbpVnextPro.Institution.Departments;
using King.AbpVnextPro.Institution.Posters;
using King.AbpVnextPro.Institution.Users;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;

namespace King.AbpVnextPro.Institution.EntityFrameworkCore;

[ConnectionStringName(InstitutionDbProperties.ConnectionStringName)]
public class InstitutionDbContext : AbpDbContext<InstitutionDbContext>, IInstitutionDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public InstitutionDbContext(DbContextOptions<InstitutionDbContext> options)
        : base(options)
    {

    }

    public DbSet<DepartmentUnit> DepartmentUnits { get; set; }

    public DbSet<Poster> Posters { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        //builder.Entity<AppUser>(b => {
        //    b.ToTable(AbpIdentityDbProperties.DbTablePrefix + "Users"); //Sharing the same table "AbpUsers" with the IdentityUser

        //    b.ConfigureByConvention();
        //    b.ConfigureAbpUser();
            
        //    /* Configure mappings for your additional properties
        //     * Also see the BlogEfCoreEntityExtensionMappings class
        //     */
        //});

        builder.ConfigureInstitution();
    }
}
