using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;
using Volo.Abp.ObjectExtending;

namespace King.AbpVnextPro.Dictionary.DataDictionarys.Dto
{
    public abstract class BaseCreateOrUpdateDataDictionaryDetailDto
    {
        public virtual Guid DataDictionaryId { get; set; }

        [Required]
        public virtual string Label { get; set; }

        [Required]
        public virtual string Value { get; set; }

        public virtual short Sort { get; set; }
    }
}