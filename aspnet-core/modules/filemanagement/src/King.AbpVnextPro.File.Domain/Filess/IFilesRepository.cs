using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories;

namespace King.AbpVnextPro.File.Filess
{
    public interface IFilesRepository : IRepository<Files, Guid>
    {
        Task<Files> FindByBlobNameAsync(string blobName);
    }
}
