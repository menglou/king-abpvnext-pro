﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiCateringCookConditionBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringCookConditionBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 商户的支付宝user_id. 商户授权后,isv能获得
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 查询页码，表示第几页
        /// </summary>
        [JsonPropertyName("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小，表示每页查询数量，不超过50
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 口碑店铺id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
