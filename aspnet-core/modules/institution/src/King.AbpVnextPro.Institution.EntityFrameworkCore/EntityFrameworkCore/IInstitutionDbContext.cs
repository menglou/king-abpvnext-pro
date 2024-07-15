using King.AbpVnextPro.Institution.Departments;
using King.AbpVnextPro.Institution.Posters;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.Institution.EntityFrameworkCore;

[ConnectionStringName(InstitutionDbProperties.ConnectionStringName)]
public interface IInstitutionDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */

    DbSet<DepartmentUnit> DepartmentUnit { get; }
    DbSet<Poster> Poster { get; }
}
