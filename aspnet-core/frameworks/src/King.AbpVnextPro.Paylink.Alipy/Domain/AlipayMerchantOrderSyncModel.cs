﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayMerchantOrderSyncModel Data Structure.
    /// </summary>
    public class AlipayMerchantOrderSyncModel : AlipayObject
    {
        /// <summary>
        /// 订单金额，单位为元。SERVICE_ORDER且不涉及金额可不传入该字段，其他场景必传
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 买家userId
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// buyer_info与buyer_user_id必选其一
        /// </summary>
        [JsonPropertyName("buyer_info")]
        public UserInfomation BuyerInfo { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 订单优惠信息
        /// </summary>
        [JsonPropertyName("discount_info_list")]
        public List<DiscountInfoData> DiscountInfoList { get; set; }

        /// <summary>
        /// 扩展信息，请参见 <a href="https://opendocs.alipay.com/mini/introduce/ordercenter">小程序订单中心</a>；<a href="https://opendocs.alipay.com/mini/00nnt3">扫码点餐</a>产品文档。
        /// </summary>
        [JsonPropertyName("ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 商品信息列表
        /// </summary>
        [JsonPropertyName("item_order_list")]
        public List<ItemOrderInfo> ItemOrderList { get; set; }

        /// <summary>
        /// 行程信息
        /// </summary>
        [JsonPropertyName("journey_order_list")]
        public List<OrderJourneyInfo> JourneyOrderList { get; set; }

        /// <summary>
        /// 物流信息  列表最多支持物流信息个数，请参考产品文档  注：若该值不为空，且物流信息同步至我的快递，则在查询订单时可返回具体物流信息
        /// </summary>
        [JsonPropertyName("logistics_info_list")]
        public List<OrderLogisticsInformationRequest> LogisticsInfoList { get; set; }

        /// <summary>
        /// 订单授权码(与订单一一对应，不是请求维度的，服务订单首次同步必传） 利用订单同步前获取的formId作为订单授权码。订单授权码对应的小程序id与买家uid与同步订单的小程序id和买家uid一致 注：当order_type为SERVICE_ORDER时必填
        /// </summary>
        [JsonPropertyName("order_auth_code")]
        public string OrderAuthCode { get; set; }

        /// <summary>
        /// 订单创建时间 当order_type为SERVICE_ORDER时必传
        /// </summary>
        [JsonPropertyName("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单修改时间，一般不需要传入。用于订单状态或数据变化较快的顺序控制，order_modified_time较晚的同步会被最终存储，order_modified_time相同的两次同步可能会被幂等处理，SERVICE_ORDER按照行业标准化接入场景必须传入该字段控制乱序
        /// </summary>
        [JsonPropertyName("order_modified_time")]
        public string OrderModifiedTime { get; set; }

        /// <summary>
        /// 订单支付时间 当pay_channel为非ALIPAY时，且订单状态已流转到“支付”或支付后时，需要将支付时间传入
        /// </summary>
        [JsonPropertyName("order_pay_time")]
        public string OrderPayTime { get; set; }

        /// <summary>
        /// 订单类型，若为空，默认为交易订单，每次请求必传 -SERVICE_ORDER：服务订单 -TRADE_ORDER：交易订单
        /// </summary>
        [JsonPropertyName("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 外部订单号 out_biz_no唯一对应一笔订单，相同的订单需传入相同的out_biz_no
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 交易对应的签约商户userId 注意：该字段自2020-02-16日起，可以不传入
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 支付金额，需要实际支付的金额。SERVICE_ORDER且不涉及金额可不传入该字段，其他场景必传
        /// </summary>
        [JsonPropertyName("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付超时时间，超过时间支付宝自行关闭订单
        /// </summary>
        [JsonPropertyName("pay_timeout_express")]
        public string PayTimeoutExpress { get; set; }

        /// <summary>
        /// 商户订单同步记录id
        /// </summary>
        [JsonPropertyName("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 卖家userId 注意：该字段自2020-02-16日起，可以不传入
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 是否需要小程序订单代理发送模版消息，Y代表需要发送，N代表不需要发送，不传默认不发送
        /// </summary>
        [JsonPropertyName("send_msg")]
        public string SendMsg { get; set; }

        /// <summary>
        /// 服务code：传入小程序后台提报的服务id，将订单与服务关联，有利于提高服务曝光机会；入参服务id的类目须与订单类型相符，若不相符将会报错；如订单类型为“外卖”，则入参的服务ID所对应的服务类目也必须得是”外卖“；service_code 通过 alipay.open.app.appcontent.function.create(小程序服务创建)接口创建服务后获取。
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 门店信息，扫码点餐获取返佣时必填。
        /// </summary>
        [JsonPropertyName("shop_info")]
        public OrderShopInfo ShopInfo { get; set; }

        /// <summary>
        /// 同步内容 -JOURNEY_ONLY 仅行程信息 -ALL 全部(默认)
        /// </summary>
        [JsonPropertyName("sync_content")]
        public string SyncContent { get; set; }

        /// <summary>
        /// 凭证信息
        /// </summary>
        [JsonPropertyName("ticket_info")]
        public TicketInfo TicketInfo { get; set; }

        /// <summary>
        /// 订单所对应的支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易号类型 1. TRADE-交易，为空默认为TRADE 2. TRANSFER-转账 3. ENTRUST-受托
        /// </summary>
        [JsonPropertyName("trade_type")]
        public string TradeType { get; set; }
    }
}
