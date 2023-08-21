using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.IdentityServer.Verification
{
    public class VerifyCode
    {
        public string Id { get; set; }
        [JsonIgnore]
        public string Code { get; set; }
        /// <summary>
        /// 验证码数据流
        /// </summary>
        [JsonIgnore]
        public byte[] Image { get; set; }
        /// <summary>
        /// base64
        /// </summary>
        public string Base64Str { get { return Convert.ToBase64String(Image); } }
    }
}
