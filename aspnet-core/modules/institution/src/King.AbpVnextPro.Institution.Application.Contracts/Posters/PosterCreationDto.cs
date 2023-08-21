using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.Institution.Posters
{
    public class PosterCreationDto : EntityDto
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Sotr { get; set; }
        //0 代表停用  1 代表正常
        public virtual int Status { get; set; }
        public Guid? TenantId { get; set; }
    }
}
