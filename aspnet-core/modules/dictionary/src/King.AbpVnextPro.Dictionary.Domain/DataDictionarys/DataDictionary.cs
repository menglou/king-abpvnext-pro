using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace King.AbpVnextPro.Dictionary.DataDictionarys
{
    public class DataDictionary : AuditedAggregateRoot<Guid>, IMultiTenant, ISoftDelete
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public short Sort { get;  set; }
        public Guid? TenantId { get; set; }
        public bool IsDeleted { get; set; }

        protected DataDictionary()
        {

        }
        public DataDictionary(Guid id,
           [NotNull] string name,
           string description,
           short sort = 0,
           Guid? tenantid = null)
        {
            Check.NotNullOrEmpty(name, nameof(name), DataDictionaryConsts.MaxNameLength);

            Id = id;
            TenantId = tenantid;
            Name = name;
            Description = description;
            Sort = sort;
        }
    }
}
