using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories;

namespace King.AbpVnextPro.File.Files
{
    public interface IFileRepository : IRepository<File, Guid>
    {
        Task<File> FindByBlobNameAsync(string blobName);
    }
}
