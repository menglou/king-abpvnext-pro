using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Auditing;

namespace King.AbpVnextPro.Openiddict.Volo.Identity
{
    public class PasswordResetDto:EntityDto
    {
        public Guid UserId { get; set; }

        [Required]
        [DisableAuditing]
        public string Password { get; set; }
    }
}
