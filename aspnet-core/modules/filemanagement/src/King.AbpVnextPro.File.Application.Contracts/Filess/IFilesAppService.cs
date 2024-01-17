using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace King.AbpVnextPro.File.Filess
{
    public interface IFilesAppService : IApplicationService
    {
        Task<FileDto> FindByBlobNameAsync(string blobName);

        Task<string> CreateAsync(FileDto input);
        Task<bool> DeleteAsync(string blobName);
        Task<string> GetFileUrl(string blobName);
    }
}
