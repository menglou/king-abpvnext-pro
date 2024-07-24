using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace King.AbpVnextPro.Dictionary.DataDictionarys
{
    public class DataDictionaryDetail : AuditedAggregateRoot<Guid>, IMultiTenant, ISoftDelete
    {
        public Guid DataDictionaryId { get; set; }

        public string Label { get;  set; }

        public string Value { get;  set; }

        public short Sort { get;  set; }

        public Guid? TenantId { get; set; }
        public bool IsDeleted { get; set; }

        protected DataDictionaryDetail()
        {

        }
        public DataDictionaryDetail(Guid id,
            [NotNull] Guid dataDictionaryId,
            [NotNull] string label,
            [NotNull] string value,
            short sort = 0, Guid? tenantId = null)
        {
            Check.NotNull(dataDictionaryId, nameof(dataDictionaryId));
            Check.NotNullOrEmpty(label, nameof(label), DataDictionaryConsts.MaxNameLength);
            Check.NotNullOrEmpty(value, nameof(value), DataDictionaryConsts.MaxNotesLength);

            Id = id;
            DataDictionaryId = dataDictionaryId;
            TenantId = tenantId;
            Label = label;
            Value = value;
            Sort = sort;
        }
    }
}
