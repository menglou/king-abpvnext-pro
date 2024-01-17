using System.IO;
using System.Threading.Tasks;
using King.AbpVnextPro.File.Localization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Volo.Abp;
using Volo.Abp.Http;
using Volo.Abp.Settings;

namespace King.AbpVnextPro.File.Filess
{
    [RemoteService]
    [Route("api/file-management/files")]
    public class FilesController : FileController
    {
        protected IFilesAppService FileAppService { get; }
        public FilesController(IFilesAppService fileAppService)
        {
            FileAppService = fileAppService;

        }

        [HttpGet]
        [Route("{blobName}")]
        public virtual async Task<FileResult> GetAsync(string blobName)
        {
            var fileDto = await FileAppService.FindByBlobNameAsync(blobName);
            return File(fileDto.Bytes, MimeTypes.GetByExtension(Path.GetExtension(fileDto.FileName)));
        }

        [Authorize]
        [HttpDelete]
        [Route("{blobName}")]
        public virtual async Task<bool> DeleteAsync(string blobName)
        {
            var res = await FileAppService.DeleteAsync(blobName);
            return res;
        }

        [HttpPost]
        [Route("upload")]
        [Authorize]
        public virtual async Task<JsonResult> CreateAsync(IFormFile file)
        {
            if (file == null)
            {
                throw new UserFriendlyException(L["FileManagement.NotHave"]);
            }

            var bytes = await file.GetAllBytesAsync();
            var result = await FileAppService.CreateAsync(new FileDto()
            {
                Bytes = bytes,
                FileName = file.FileName
            });
            return new JsonResult(result);
        }

        [HttpPost]
        [Route("getfileurl")]
        [Authorize]
        public virtual async Task<string> GetFileUrl(string blobName)
        {
            string baseurl=await FileAppService.GetFileUrl(blobName);
            return baseurl;
        }
    }
}
