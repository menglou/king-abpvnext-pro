using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Settings;
using Volo.Abp.Validation;
using Volo.Abp;
using King.AbpVnextPro.File.Settings;
using Microsoft.Extensions.Configuration;

namespace King.AbpVnextPro.File.Filess
{
    public class FilesAppService : FileAppService, IFilesAppService
    {
        protected IFilesManager FileManager { get; }
        protected ISettingProvider _settingProvider { get; }

        protected IConfiguration _configuration;

        public FilesAppService(IFilesManager fileManager, ISettingProvider settingProvider, IConfiguration configuration)
        {
            FileManager = fileManager;
            _settingProvider = settingProvider;
            _configuration = configuration;
        }

        public virtual async Task<FileDto> FindByBlobNameAsync(string blobName)
        {
            Check.NotNullOrWhiteSpace(blobName, nameof(blobName));

            var file = await FileManager.FindByBlobNameAsync(blobName);
            var bytes = await FileManager.GetBlobAsync(blobName);

            return new FileDto
            {
                Bytes = bytes,
                FileName = file.FileName
            };
        }


        public virtual async Task<string> CreateAsync(FileDto input)
        {
            await CheckFile(input);

            var file = await FileManager.CreateAsync(input.FileName, input.Bytes);

            return file.BlobName;
        }

        public virtual async Task<bool> DeleteAsync(string blobName)
        {
            var res = await FileManager.DeleteAsync(blobName);

            return res;
        }
        //获取文件读取url
        public virtual async Task<string> GetFileUrl(string blobName)
        {
            string baseurl = string.Empty;
            baseurl = await _settingProvider.GetOrNullAsync(FileSettings.BaseUploadUrl);
            if (baseurl == null)
            {
                baseurl = _configuration.GetSection("AuthServer:Authority").Value;
            }
            return $"{baseurl}/api/file-management/files/{blobName}";
        }

        protected virtual async Task CheckFile(FileDto input)
        {
            if (input.Bytes.IsNullOrEmpty())
            {
                throw new AbpValidationException("Bytes can not be null or empty!",
                    new List<ValidationResult>
                    {
                        new ValidationResult("Bytes can not be null or empty!", new[] {"Bytes"})
                    });
            }

            var allowedMaxFileSize = await _settingProvider.GetAsync<int>(FileSettings.AllowedMaxFileSize);//kb
            var allowedUploadFormats = (await _settingProvider.GetOrNullAsync(FileSettings.AllowedUploadFormats))
                ?.Split(",", StringSplitOptions.RemoveEmptyEntries);

            if (input.Bytes.Length > allowedMaxFileSize * 1024)
            {
                throw new UserFriendlyException(L["FileManagement.ExceedsTheMaximumSize", allowedMaxFileSize]);
            }

            if (allowedUploadFormats == null || !allowedUploadFormats.Contains(Path.GetExtension(input.FileName)))
            {
                throw new UserFriendlyException(L["FileManagement.NotValidFormat"]);
            }
        }

    }
}
