using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.Dictionary.DataDictionarys.Dto
{
    public class GetDictionaryDetailInputDto: PagedAndSortedResultRequestDto
    {
        [Required]
        public Guid DataDictionaryId { get; set; }
    }
}