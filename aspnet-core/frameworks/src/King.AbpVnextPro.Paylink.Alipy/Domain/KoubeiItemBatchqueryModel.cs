﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiItemBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiItemBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 服务商、服务商员工、商户、商户员工等口碑角色操作时必填，对应为《koubei.member.data.oauth.query》中的auth_code，默认有效期24小时；
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 商品Id,多个用,分割，最多支持传5个,如果不传递则查询商户下所有商品，但是不返回适用门店字段，使用了该参数，则无需填写page_no和page_size
        /// </summary>
        [JsonPropertyName("item_ids")]
        public string ItemIds { get; set; }

        /// <summary>
        /// 操作上下文 isv角色操作时必填；其他角色不需填写
        /// </summary>
        [JsonPropertyName("operation_context")]
        public KoubeiOperationContext OperationContext { get; set; }

        /// <summary>
        /// 页码，留空标示第一页，默认10个结果为一页
        /// </summary>
        [JsonPropertyName("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 每页记录数，默认10，最大20
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
