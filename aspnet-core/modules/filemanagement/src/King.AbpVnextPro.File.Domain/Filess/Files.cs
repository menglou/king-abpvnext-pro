using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;
using Volo.Abp;

namespace King.AbpVnextPro.File.Filess
{
    public class Files : FullAuditedAggregateRoot<Guid>, IMultiTenant
    {
        public virtual Guid? TenantId { get; protected set; }

        [NotNull]
        public virtual string FileName { get; protected set; }

        [NotNull]
        public virtual string BlobName { get; protected set; }

        public virtual long ByteSize { get; protected set; }

        protected Files() { }

        public Files(Guid id,[NotNull] string fileName, [NotNull] string blobName, long byteSize, Guid? tenantId=null) : base(id)
        {
            TenantId = tenantId;
            FileName = Check.NotNullOrWhiteSpace(fileName, nameof(fileName));
            BlobName = Check.NotNullOrWhiteSpace(blobName, nameof(blobName));
            ByteSize = byteSize;
        }

    }
}
