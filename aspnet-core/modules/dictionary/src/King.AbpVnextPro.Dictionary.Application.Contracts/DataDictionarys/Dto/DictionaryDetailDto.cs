using System;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.Dictionary.DataDictionarys.Dto
{
    public class DictionaryDetailDto:  ExtensibleAuditedEntityDto<Guid>
    {
        public Guid DataDictionaryId { get; set; }

        public string Label { get; set; }

        public string Value { get; set; }

        public short Sort { get; set; }
    }
}