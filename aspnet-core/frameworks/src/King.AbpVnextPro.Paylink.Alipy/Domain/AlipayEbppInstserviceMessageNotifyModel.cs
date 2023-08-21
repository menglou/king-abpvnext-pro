﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEbppInstserviceMessageNotifyModel Data Structure.
    /// </summary>
    public class AlipayEbppInstserviceMessageNotifyModel : AlipayObject
    {
        /// <summary>
        /// 余额
        /// </summary>
        [JsonPropertyName("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 账单金额
        /// </summary>
        [JsonPropertyName("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 账单日期等时间格式
        /// </summary>
        [JsonPropertyName("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 账单机构缩写，广东移动，江苏电网，支付宝分配
        /// </summary>
        [JsonPropertyName("bill_inst")]
        public string BillInst { get; set; }

        /// <summary>
        /// 如浙江电力，浙江移动等，支付宝分配
        /// </summary>
        [JsonPropertyName("bill_inst_desc")]
        public string BillInstDesc { get; set; }

        /// <summary>
        /// 通知关键字，户号，手机号
        /// </summary>
        [JsonPropertyName("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 账单缴清截止日期
        /// </summary>
        [JsonPropertyName("bill_last_date")]
        public string BillLastDate { get; set; }

        /// <summary>
        /// 通知流水号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单业务类型
        /// </summary>
        [JsonPropertyName("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 业务类型，通信，缴费，还款等动帐服务通知
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 标准kv，json数据
        /// </summary>
        [JsonPropertyName("extend_data")]
        public string ExtendData { get; set; }

        /// <summary>
        /// 通知时间
        /// </summary>
        [JsonPropertyName("notify_date")]
        public string NotifyDate { get; set; }

        /// <summary>
        /// 通知描述
        /// </summary>
        [JsonPropertyName("notify_desc")]
        public string NotifyDesc { get; set; }

        /// <summary>
        /// 通知功能码，支付宝分配
        /// </summary>
        [JsonPropertyName("notify_type")]
        public string NotifyType { get; set; }

        /// <summary>
        /// 二级业务类型，话费，流量，水费，电费等
        /// </summary>
        [JsonPropertyName("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 阀值金额，低额触发的阀值
        /// </summary>
        [JsonPropertyName("threshold_amount")]
        public string ThresholdAmount { get; set; }

        /// <summary>
        /// 用户地址
        /// </summary>
        [JsonPropertyName("user_address")]
        public string UserAddress { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
