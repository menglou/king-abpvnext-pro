using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Services;

namespace King.AbpVnextPro.File.Files
{
    public interface IFileManager : IDomainService
    {
        Task<File> FindByBlobNameAsync(string blobName);

        Task<File> CreateAsync(string fileName, byte[] bytes);

        Task<byte[]> GetBlobAsync(string blobName);
    }
}
