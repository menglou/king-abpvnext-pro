using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.Institution.Posters
{
    public class BatchUserPosterCreationDto: EntityDto
    {
        public BatchUserPosterCreationDto()
        {
            UserId = new List<Guid>();
        }
        public List<Guid> UserId { get; set; }
        public Guid PosterId { get; set; }
    }
}
