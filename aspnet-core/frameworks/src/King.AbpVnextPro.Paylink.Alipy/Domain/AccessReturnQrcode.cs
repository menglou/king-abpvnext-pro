﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AccessReturnQrcode Data Structure.
    /// </summary>
    public class AccessReturnQrcode : AlipayObject
    {
        /// <summary>
        /// 采购单ID
        /// </summary>
        [JsonPropertyName("asset_purchase_id")]
        public string AssetPurchaseId { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [JsonPropertyName("express_no")]
        public string ExpressNo { get; set; }

        /// <summary>
        /// 外部单号（调用方业务主键）
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 二维码token值
        /// </summary>
        [JsonPropertyName("qrcode")]
        public string Qrcode { get; set; }
    }
}
