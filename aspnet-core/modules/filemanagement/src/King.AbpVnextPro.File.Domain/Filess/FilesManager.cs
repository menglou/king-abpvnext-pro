using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Services;
using Volo.Abp.Guids;
using Volo.Abp.MultiTenancy;
using Volo.Abp;
using Volo.Abp.BlobStoring;
using System.Reflection;
using System.Security.Cryptography;

namespace King.AbpVnextPro.File.Filess
{
    public class FilesManager : DomainService, IFilesManager
    {
        protected IFilesRepository FileRepository { get; }
        protected IBlobContainer BlobContainer { get; }

        public FilesManager(IFilesRepository fileRepository, IBlobContainer blobContainer)
        {
            FileRepository = fileRepository;
            BlobContainer = blobContainer;
        }

        public virtual async Task<Files> FindByBlobNameAsync(string blobName)
        {
            Check.NotNullOrWhiteSpace(blobName, nameof(blobName));

            return await FileRepository.FindByBlobNameAsync(blobName);
        }

        public virtual async Task<Files> CreateAsync(string fileName, byte[] bytes)
        {
            Check.NotNullOrWhiteSpace(fileName, nameof(fileName));
            var blobName = Guid.NewGuid().ToString("N");

            var file = await FileRepository.InsertAsync(new Files(GuidGenerator.Create(), CurrentTenant.Id, fileName, blobName, bytes.Length));

            await BlobContainer.SaveAsync(blobName, bytes);

            return file;
        }

        public virtual async Task<byte[]> GetBlobAsync(string blobName)
        {
            Check.NotNullOrWhiteSpace(blobName, nameof(blobName));

            return await BlobContainer.GetAllBytesAsync(blobName);
        }

        public virtual async Task<bool> DeleteAsync(string blobName)
        {
            //删除本地文件的
            await BlobContainer.DeleteAsync(blobName);
            //删除file 表中的记录
            await FileRepository.DeleteAsync(x => x.BlobName == blobName);
           
            return true;
        }
    }
}
