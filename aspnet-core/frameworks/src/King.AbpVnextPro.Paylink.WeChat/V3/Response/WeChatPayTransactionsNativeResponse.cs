﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.WeChat.V3.Response
{
    /// <summary>
    /// 基础支付 - Native支付 - 统一下单 - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_1.shtml">Native支付 - 统一下单API</a> - 最新更新时间：2020.05.26</para>
    /// </remarks>
    public class WeChatPayTransactionsNativeResponse : WeChatPayResponse
    {
        /// <summary>
        /// 二维码链接
        /// </summary>
        /// <remarks>
        /// 此URL用于生成支付二维码，然后提供给用户扫码支付。
        /// 注意：code_url并非固定值，使用时按照URL格式转成二维码即可。
        /// <para>示例值：weixin://wxpay/bizpayurl/up?pr=NwY5Mz9&amp;groupid=00</para>
        /// </remarks>
        [JsonPropertyName("code_url")]
        public string CodeUrl { get; set; }
    }
}
