using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace King.AbpVnextPro.File.Files
{
    public class FileDto
    {
        [Required]
        public byte[] Bytes { get; set; }

        [Required]
        public string FileName { get; set; }
    }
}
