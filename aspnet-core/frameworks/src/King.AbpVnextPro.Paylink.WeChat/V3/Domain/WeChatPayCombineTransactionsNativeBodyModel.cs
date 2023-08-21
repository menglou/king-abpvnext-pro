﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.WeChat.V3.Domain
{
    /// <summary>
    /// 基础支付、基础支付(服务商) - 合单支付 - 合单Native下单 - 请求JSON参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_5.shtml">基础支付 - 合单支付 -  合单Native下单API</a> - 最新更新时间：2021.08.23</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter5_1_5.shtml">基础支付(服务商) - 合单支付 -  合单Native下单API</a> - 最新更新时间：2021.08.23</para>
    /// </remarks>
    public class WeChatPayCombineTransactionsNativeBodyModel : WeChatPayObject
    {
        /// <summary>
        /// 合单商户appid
        /// </summary>
        /// <remarks>
        /// 合单发起方的appid。
        /// <para>示例值：wxd678efh567hg6787</para>
        /// </remarks>
        [JsonPropertyName("combine_appid")]
        public string CombineAppId { get; set; }

        /// <summary>
        /// 合单商户号
        /// </summary>
        /// <remarks>
        /// 合单发起方商户号。
        /// <para>示例值：1900000109</para>
        /// </remarks>
        [JsonPropertyName("combine_mchid")]
        public string CombineMchId { get; set; }

        /// <summary>
        /// 合单商户订单号
        /// </summary>
        /// <remarks>
        /// 合单支付总订单号，要求32个字符内，只能是数字、大小写字母_-|*@ ，且在同一个商户号下唯一 。
        /// <para>示例值：P20150806125346</para>
        /// </remarks>
        [JsonPropertyName("combine_out_trade_no")]
        public string CombineOutTradeNo { get; set; }

        /// <summary>
        /// 场景信息
        /// </summary>
        /// <remarks>
        /// 支付场景描述
        /// </remarks>
        [JsonPropertyName("scene_info")]
        public SceneInfo SceneInfo { get; set; }

        /// <summary>
        /// 子单信息
        /// </summary>
        /// <remarks>
        /// 最多支持子单条数：50
        /// </remarks>
        [JsonPropertyName("sub_orders")]
        public List<CombineSubOrderInfo> SubOrders { get; set; }

        /// <summary>
        /// 交易起始时间
        /// </summary>
        /// <remarks>
        /// 订单生成时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss表示时分秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35+08:00表示，北京时间2015年5月20日 13点29分35秒。
        /// <para>示例值：2019-12-31T15:59:60+08:00</para>
        /// </remarks>
        [JsonPropertyName("time_start")]
        public string TimeStart { get; set; }

        /// <summary>
        /// 交易结束时间
        /// </summary>
        /// <remarks>
        /// 订单失效时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss表示时分秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35+08:00表示，北京时间2015年5月20日 13点29分35秒。
        /// <para>示例值：2019-12-31T15:59:60+08:00</para>
        /// </remarks>
        [JsonPropertyName("time_expire")]
        public string TimeExpire { get; set; }

        /// <summary>
        /// 通知地址
        /// </summary>
        /// <remarks>
        /// 接收微信支付异步通知回调地址，通知url必须为直接可访问的URL，不能携带参数。
        /// 格式: URL
        /// <para>示例值：https://yourapp.com/notify</para>
        /// </remarks>
        [JsonPropertyName("notify_url")]
        public string NotifyUrl { get; set; }
    }
}
