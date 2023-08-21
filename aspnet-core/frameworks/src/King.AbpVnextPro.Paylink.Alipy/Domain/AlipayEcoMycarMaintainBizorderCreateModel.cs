﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEcoMycarMaintainBizorderCreateModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarMaintainBizorderCreateModel : AlipayObject
    {
        /// <summary>
        /// 预约确认时间yyyy-MM-dd HH:mm:ss。门店确认预约时间。门店确认后，预约流程生效，用户可到店服务。
        /// </summary>
        [JsonPropertyName("appoint_affirm_time")]
        public string AppointAffirmTime { get; set; }

        /// <summary>
        /// 预约结束时间yyyy-MM-dd HH:mm:ss。用户选择的预约结束时间，用于判断用户是否在预约时间到店服务。
        /// </summary>
        [JsonPropertyName("appoint_end_time")]
        public string AppointEndTime { get; set; }

        /// <summary>
        /// 预约开始时间yyyy-MM-dd HH:mm:ss，用户选择的预约开始时间，用于判断用户是否在预约时间到店服务。
        /// </summary>
        [JsonPropertyName("appoint_start_time")]
        public string AppointStartTime { get; set; }

        /// <summary>
        /// 预约状态(0-待确认预约 1-确认预约)。有预约流程的订单，门店确认前为待确认预约，门店确认后为 确认预约。
        /// </summary>
        [JsonPropertyName("appoint_status")]
        public long AppointStatus { get; set; }

        /// <summary>
        /// 到店时间yyyy-MM-dd HH:mm:ss。 用户到店时间，用于判断用户是否在预约时间到店服务。
        /// </summary>
        [JsonPropertyName("arrive_time")]
        public string ArriveTime { get; set; }

        /// <summary>
        /// ISV订单状态文案。由ISV上传自己订单的状态，用于订单数据的匹配和对账。
        /// </summary>
        [JsonPropertyName("biz_status_txt")]
        public string BizStatusTxt { get; set; }

        /// <summary>
        /// 订单类型，1：洗车，2：保养，4：4s店
        /// </summary>
        [JsonPropertyName("biz_type")]
        public long BizType { get; set; }

        /// <summary>
        /// 车主平台我的爱车ID。可通过接口查询爱车详情。 请查看alipay.eco.mycar.dataservice.maintainvehicle.share接口。
        /// </summary>
        [JsonPropertyName("car_id")]
        public string CarId { get; set; }

        /// <summary>
        /// 服务项列表
        /// </summary>
        [JsonPropertyName("order_server_list")]
        public List<MaintainBizOrder> OrderServerList { get; set; }

        /// <summary>
        /// 车主平台业务订单状态  1-未支付；  4-已关闭；  6-支付完成；  7-已出库；  8-已收货；   11-服务开始；  55-服务完成/已核销；  56-订单完成；
        /// </summary>
        [JsonPropertyName("order_status")]
        public long OrderStatus { get; set; }

        /// <summary>
        /// 原始金额，服务原价累计后金额。金额单位(元)，保留两位小数。  原始金额 = 服务原始价格 * 数量 + 商品售卖价格 * 数量
        /// </summary>
        [JsonPropertyName("original_cost")]
        public string OriginalCost { get; set; }

        /// <summary>
        /// ISV业务订单号，ISV上传订单场景，由业务方保证唯一
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 外部门店编号，订单创建时对应的门店的外部编号，要保证编码在车主平台已经创建对应的门店数据，即有与之唯一匹配的车主平台shop_id
        /// </summary>
        [JsonPropertyName("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 支付时间yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 交易金额。下单时实际支付金额。金额单位(元)，保留两位小数。  交易金额 = 服务售卖价格 * 数量 + 商品售卖价格 * 数量
        /// </summary>
        [JsonPropertyName("real_cost")]
        public string RealCost { get; set; }

        /// <summary>
        /// 车主平台门店编号
        /// </summary>
        [JsonPropertyName("shop_id")]
        public long ShopId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
