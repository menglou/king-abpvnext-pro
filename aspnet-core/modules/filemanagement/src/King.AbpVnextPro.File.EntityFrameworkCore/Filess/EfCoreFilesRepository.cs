using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp;
using King.AbpVnextPro.File.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace King.AbpVnextPro.File.Filess
{
    public class EfCoreFilesRepository : EfCoreRepository<IFileDbContext, Files, Guid>, IFilesRepository
    {
        public EfCoreFilesRepository(IDbContextProvider<IFileDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<Files> FindByBlobNameAsync(string blobName)
        {
            Check.NotNullOrWhiteSpace(blobName, nameof(blobName));
            var dbset = await GetDbSetAsync();
            return await dbset.FirstOrDefaultAsync(p => p.BlobName == blobName);
        }
    }
}
