using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Services;

namespace King.AbpVnextPro.File.Filess
{
    public interface IFilesManager : IDomainService
    {
        Task<Files> FindByBlobNameAsync(string blobName);

        Task<Files> CreateAsync(string fileName, byte[] bytes);

        Task<byte[]> GetBlobAsync(string blobName);
        Task<bool> DeleteAsync(string blobName);
    }
}
