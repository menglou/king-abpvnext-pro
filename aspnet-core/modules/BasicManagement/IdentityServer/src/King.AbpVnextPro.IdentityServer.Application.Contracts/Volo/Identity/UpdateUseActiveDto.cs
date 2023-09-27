using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.IdentityServer.Volo.Identity
{
    public class UpdateUseActiveDto:EntityDto
    {
        public Guid Id { get; set; }

        public bool IsActive { get; set; }
    }
}
