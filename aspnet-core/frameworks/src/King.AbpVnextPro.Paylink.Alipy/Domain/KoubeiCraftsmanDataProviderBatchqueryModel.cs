﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiCraftsmanDataProviderBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiCraftsmanDataProviderBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 服务商、服务商员工、商户、商户员工等口碑角色操作时必填，对应为 koubei.member.data.oauth.query 中的 auth_code，默认有效期24小时；ISV自身角色操作的时候，无需传该参数
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 手艺人id (如果传入craftsman_ids，会忽略其他参数：注意，不能与shop_id同时为空),以数组方式传值
        /// </summary>
        [JsonPropertyName("craftsman_ids")]
        public List<string> CraftsmanIds { get; set; }

        /// <summary>
        /// 手艺人外部id（如果没有传craftsman_ids，传了craftsman_external_ids，会忽略其他参数，注意，不能与shop_id 同时为空）
        /// </summary>
        [JsonPropertyName("out_craftsman_ids")]
        public List<string> OutCraftsmanIds { get; set; }

        /// <summary>
        /// 页码，大于0，最大为int的最大值
        /// </summary>
        [JsonPropertyName("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 每页的条数，大于0，最大不超过100条
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 手艺人码对应的门店，只有指定了码门店字段，才会返回手艺人码信息
        /// </summary>
        [JsonPropertyName("qr_code_shop_id")]
        public string QrCodeShopId { get; set; }

        /// <summary>
        /// 是否推荐 (true 返回在c端展示的手艺人，false 返回c端隐藏的手艺人，不传表示不过滤）
        /// </summary>
        [JsonPropertyName("recommend")]
        public bool Recommend { get; set; }

        /// <summary>
        /// 口碑门店id（不能与craftsman_ids和out_craftsman_ids同时为空）
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
