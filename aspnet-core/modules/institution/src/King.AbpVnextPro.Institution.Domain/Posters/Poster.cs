using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;
using Volo.Abp.MultiTenancy;

namespace King.AbpVnextPro.Institution.Posters
{
    /// <summary>
    /// 岗位
    /// </summary>
    public class Poster : FullAuditedAggregateRoot<Guid>, IMultiTenant
    {
        public virtual string Name { get; set; }
        public virtual string Code { get; set; }

        public virtual string Sotr { get; set; }
        //0 代表停用  1 代表正常
        public virtual int Status { get; set; }
        public virtual Guid? TenantId { get; set; }

        public virtual ICollection<UserPoster> UserPosters { get; set; }

        public Poster()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationUnit"/> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="name">Display name.</param>
        /// <param name="code">Parent's Id or null if OU is a root.</param>
        /// <param name="sotr"></param>
        /// <param name="tenantId">Tenant's Id or null for host.</param>
        public Poster(Guid id, string name,string code,string sotr,int status, Guid? tenantId = null)
            : base(id)
        {
            TenantId = tenantId;
            Name = name;
            Code = code;
            Sotr = sotr;
            Status = status;
            UserPosters=new Collection<UserPoster>();
        }
    }
}
