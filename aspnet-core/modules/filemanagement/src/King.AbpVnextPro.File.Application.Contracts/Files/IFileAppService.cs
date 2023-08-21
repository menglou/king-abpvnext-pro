using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace King.AbpVnextPro.File.Files
{
    public interface IFileAppService : IApplicationService
    {
        Task<FileDto> FindByBlobNameAsync(string blobName);

        Task<string> CreateAsync(FileDto input);
    }
}
