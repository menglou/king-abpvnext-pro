﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceTradeApplyModel Data Structure.
    /// </summary>
    public class AlipayCommerceTradeApplyModel : AlipayObject
    {
        /// <summary>
        /// 订单费用详情，用于在订单确认页面展示
        /// </summary>
        [JsonPropertyName("amount_detail")]
        public string AmountDetail { get; set; }

        /// <summary>
        /// 接口请求渠道编码，由支付宝提供
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 接口版本号
        /// </summary>
        [JsonPropertyName("interface_version")]
        public string InterfaceVersion { get; set; }

        /// <summary>
        /// 用于标识操作模型，由支付宝配置提供
        /// </summary>
        [JsonPropertyName("op_code")]
        public string OpCode { get; set; }

        /// <summary>
        /// 场景的数据表示. json 数组格式，根据场景不同的模型传入不同参数，由支付宝负责提供参数集合
        /// </summary>
        [JsonPropertyName("order_detail")]
        public string OrderDetail { get; set; }

        /// <summary>
        /// 用于标识数据模型，由支付宝配置提供
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 场景覆盖的目标人群标识，支持支付宝userId、身份证号、支付宝登录号、支付宝绑定手机号；
        /// </summary>
        [JsonPropertyName("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 场景覆盖人群id类型
        /// </summary>
        [JsonPropertyName("target_id_type")]
        public string TargetIdType { get; set; }

        /// <summary>
        /// 交易请求参数
        /// </summary>
        [JsonPropertyName("trade_apply_params")]
        public TradeApplyParams TradeApplyParams { get; set; }
    }
}
