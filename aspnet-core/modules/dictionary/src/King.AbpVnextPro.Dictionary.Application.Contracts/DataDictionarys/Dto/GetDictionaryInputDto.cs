using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.Dictionary.DataDictionarys.Dto
{
    public class GetDictionaryInputDto: PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}