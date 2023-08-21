using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Validation;

namespace King.AbpVnextPro.Dictionary.DataDictionarys.Dto
{
    public abstract class BaseCreateOrUpdateDictionaryDto
    {
        [Required]
        [DynamicStringLength(typeof(DataDictionaryConsts), nameof(DataDictionaryConsts.MaxNameLength))]
        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual short Sort { get; set; }
    }
}