﻿using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.ObjectExtending;

namespace King.AbpVnextPro.Dictionary.DataDictionarys.Dto
{
    public class DictionaryDto: ExtensibleAuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public short Sort { get; set; }
    }
}