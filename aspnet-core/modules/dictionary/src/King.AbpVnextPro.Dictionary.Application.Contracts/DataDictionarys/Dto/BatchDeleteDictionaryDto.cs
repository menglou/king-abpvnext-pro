using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.Dictionary.DataDictionarys.Dto
{
    public class BatchDeleteDictionaryDto:EntityDto
    {
        public List<Guid>Ids { get; set; }
        public BatchDeleteDictionaryDto()
        {
            Ids = new List<Guid>();
        }
    }
}
