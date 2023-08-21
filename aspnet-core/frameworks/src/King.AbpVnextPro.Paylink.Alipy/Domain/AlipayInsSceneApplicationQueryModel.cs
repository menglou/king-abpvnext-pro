﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayInsSceneApplicationQueryModel Data Structure.
    /// </summary>
    public class AlipayInsSceneApplicationQueryModel : AlipayObject
    {
        /// <summary>
        /// 投保订单号;当商户生成的外部投保业务号不传时则必传
        /// </summary>
        [JsonPropertyName("application_no")]
        public string ApplicationNo { get; set; }

        /// <summary>
        /// 商户生成的外部投保业务号;当投保订单号不传时必传
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品编码;当投保订单号不传时必传.
        /// </summary>
        [JsonPropertyName("prod_code")]
        public string ProdCode { get; set; }
    }
}
