using System.IO;
using System.Threading.Tasks;
using King.AbpVnextPro.File.Localization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Volo.Abp;
using Volo.Abp.Http;

namespace King.AbpVnextPro.File.Files
{
    [RemoteService]
    [Route("api/file-management/files")]
    public class FilesController : FileController
    {
        protected IFileAppService FileAppService { get; }
        public FilesController(IFileAppService fileAppService)
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
    }
}
