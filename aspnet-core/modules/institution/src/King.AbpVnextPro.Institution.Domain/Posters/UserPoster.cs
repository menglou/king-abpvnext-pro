using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;
using Volo.Abp.MultiTenancy;

namespace King.AbpVnextPro.Institution.Posters
{
    public class UserPoster : CreationAuditedEntity, IMultiTenant
    {
        public virtual Guid UserId { get; set; }
       
        public virtual Guid PotserId { get; set; }
        public Guid? TenantId { get; set; }

        public UserPoster()
        {

        }
        public UserPoster(Guid userId, Guid posterId, Guid? tenantId = null)
        {
            UserId = userId;
            PotserId = posterId;
            TenantId = tenantId;
        }
        public override object[] GetKeys()
        {
            return new object[] { UserId, PotserId };
        }
    }
}
