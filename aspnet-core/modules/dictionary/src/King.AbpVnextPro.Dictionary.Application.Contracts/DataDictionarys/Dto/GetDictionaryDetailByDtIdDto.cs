using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.Dictionary.DataDictionarys.Dto
{
    public class GetDictionaryDetailByDtIdDto: PagedAndSortedResultRequestDto
    {
        public Guid DictionaryId { get; set; }
    }
}
