using King.AbpVnextPro.Institution.Departments;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Users;

namespace King.AbpVnextPro.Institution.Users
{
    public class AppUser : FullAuditedAggregateRoot<Guid>, IUser
    {
        #region Base properties

        /* These properties are shared with the IdentityUser entity of the Identity module.
         * Do not change these properties through this class. Instead, use Identity module
         * services (like IdentityUserManager) to change them.
         * So, this properties are designed as read only!
         */

        public virtual Guid? TenantId { get; private set; }

        public virtual string UserName { get; private set; }

        public virtual string Name { get; private set; }

        public virtual string Surname { get; private set; }

        public virtual string Email { get; private set; }

        public virtual bool EmailConfirmed { get; private set; }

        public virtual string PhoneNumber { get; private set; }

        public virtual bool PhoneNumberConfirmed { get; private set; }

        public bool IsActive { get; set; }




        #endregion
        public virtual ICollection<UserDepartmentUnit> UserDepartmentUnits { get; private set; }
        /* Add your own properties here. Example:
         *
         * public string MyProperty { get; set; }
         *
         * If you add a property and using the EF Core, remember these;
         *
         * 1. Update BlogDbContext.OnModelCreating
         * to configure the mapping for your new property
         * 2. Update BlogEfCoreEntityExtensionMappings to extend the IdentityUser entity
         * and add your new property to the migration.
         * 3. Use the Add-Migration to add a new database migration.
         * 4. Run the .DbMigrator project (or use the Update-Database command) to apply
         * schema change to the database.
         */

        private AppUser()
        {
            UserDepartmentUnits=new Collection<UserDepartmentUnit>();
        }
    }
}
