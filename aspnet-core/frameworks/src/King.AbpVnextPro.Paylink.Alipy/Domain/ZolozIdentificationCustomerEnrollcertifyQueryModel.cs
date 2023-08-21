﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ZolozIdentificationCustomerEnrollcertifyQueryModel Data Structure.
    /// </summary>
    public class ZolozIdentificationCustomerEnrollcertifyQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务单据号，用于核对和排查
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 0：匿名注册  1：匿名认证   2：实名认证
        /// </summary>
        [JsonPropertyName("face_type")]
        public long FaceType { get; set; }

        /// <summary>
        /// 是否需要返回人脸照片
        /// </summary>
        [JsonPropertyName("need_img")]
        public bool NeedImg { get; set; }

        /// <summary>
        /// zimId，用于查询认证结果
        /// </summary>
        [JsonPropertyName("zim_id")]
        public string ZimId { get; set; }
    }
}
