﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayMarketingCashticketTemplateCreateModel Data Structure.
    /// </summary>
    public class AlipayMarketingCashticketTemplateCreateModel : AlipayObject
    {
        /// <summary>
        /// 面额（仅用于有资金定额票,有资金定额票不能填写此值）。每张票最多可以抵扣的金额。币种为人民币，单位为元。小数点以后最多保留两位，没有抵扣完的面额，可以下次使用；该数值有效范围为0.1~9999
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 商家品牌名称。最多12个字符 商户自定义，在通用模板中展示在票LOGO下方。根据票使用场景的不同，该信息的展示位置可能会有不同。
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 扩展字段,JSON字符串。目前支持使用模式扩展：{"useMode":"H5","useModeData":{"url":"http://www.yourdomian.com/yourusepage.htm","signKeys":"voucherId,userId,tag","charset":"UTF-8","signType":"RSA2","tag":"this is my tag"}} 其中如果useMode表示自定义的使用模式类型，目前仅支持"H5",表示在票详情页按钮跳转至自定义H5页面，当传入useMode参数后，将会检查useModeData对象数据，其中的url为必传参数;url字段表示客制化使用按钮跳转链接，传入该字段后在票详情使用时点击效果将会跳转此链接，链接将进行白名单过滤，如果无法接入成功请联系技术支持;signKeys字段表示跳转至客制链接时的加签字段，如果不传默认为voucherId,userId,tag;signType为加签类型，目前支持RSA及RSA2,如果不传则不会加签;charset为链接编码格式，不传默认为UTF-8;tag为自定义参数，会直接透传回使用链接;当传入合法加签信息后，票使用链接将为http://www.yourdomain.com/yourusepage.htm?voucherId=当前票id&userId=当前用户id&tag=传入tag&sign=对应算法及key生成的加签数据
        /// </summary>
        [JsonPropertyName("extension_info")]
        public string ExtensionInfo { get; set; }

        /// <summary>
        /// 出资人登录账号。用于发票的资金会从该账号划拨到发票专用账户上。当调用创建接口成功后，会返回付款订单页面，仅当前传入票金账号可进行付款，付款完成后票变更为激活状态，可进行发放
        /// </summary>
        [JsonPropertyName("fund_account")]
        public string FundAccount { get; set; }

        /// <summary>
        /// 票行业场景标识。可枚举，目前支持“饮水小票”(WATER_TICKET)，充电小票（BATTERY_TICKET）场景值会关联当前票的展示模板，默认描述等信息，若需特殊场景接入，请联系技术支持。该场景码用于收银台、支付结果页、个人用户账单。目前暂不支持自定义票展示名称
        /// </summary>
        [JsonPropertyName("group_code")]
        public string GroupCode { get; set; }

        /// <summary>
        /// 备注字段，商家可用于填写一些额外的说明，不能超过128个字
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// https://www.yourdomain.com/reieve/ticket/flux
        /// </summary>
        [JsonPropertyName("notify_uri")]
        public string NotifyUri { get; set; }

        /// <summary>
        /// 外部业务单号。用作幂等控制。同一个pid下相同的外部业务单号作唯一键
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 发放结束时间，晚于该时间不能发票。票的发放结束时间和发放开始时间跨度不能大于5年（一年统一按照365天来计算）。发放结束时间必须晚于发放开始时间。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 发放开始时间，早于该时间不能发票。发放开始时间不能大于当前时间15天。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("publish_start_time")]
        public string PublishStartTime { get; set; }

        /// <summary>
        /// 重定向地址。支付成功后需要重定向的地址，如果为空则不做重定向
        /// </summary>
        [JsonPropertyName("redirect_uri")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// 规则配置，JSON字符串，{"PID": "2088512417841101,2088512417841102", "STORE": "123456,678901"}，其中PID表示可以核销该票的pid列表，多个值用英文逗号隔开，PID为必传，STORE表示可以核销该票的内部门店ID，非必填。PID和STOREID的最大数量均不能超过3000，允许用户使用MerchantMarketingSign字段自定义核销规则。
        /// </summary>
        [JsonPropertyName("rule_conf")]
        public string RuleConf { get; set; }

        /// <summary>
        /// 票可用时段，JSON数组字符串，空数组即[]，表示不限制，指定每周时间段示例：[{"day_rule": "1,2,3,4,5", "time_begin": "09:00:00", "time_end": "22:00:00"}, {"day_rule": "6,7", "time_begin": "08:00:00", "time_end": "23:00:00"}]，数组中每个元素都包含三个key：day_rule, time_begin, time_end，其中day_rule表示周几，取值范围[1, 2, 3, 4, 5, 6, 7]（周7表示星期日），多个值使用英文逗号隔开；time_begin和time_end分别表示生效起始时间和结束时间，格式为HH:mm:ss。另外，数组中各个时间规则是或关系。例如，[{"day_rule": "1,2,3,4,5", "time_begin": "09:00:00", "time_end": "22:00:00"}, {"day_rule": "6,7", "time_begin": "08:00:00", "time_end": "23:00:00"}]表示在每周的一，二，三，四，五的早上9点到晚上10点票可用或者每周的星期六和星期日的早上8点到晚上11点票可用
        /// </summary>
        [JsonPropertyName("ticket_available_time")]
        public string TicketAvailableTime { get; set; }

        /// <summary>
        /// 票使用说明。JSON数组字符串，最多可以有20条，每条最多300字。如果未传入该字段，将填充为默认描述
        /// </summary>
        [JsonPropertyName("ticket_description")]
        public string TicketDescription { get; set; }

        /// <summary>
        /// 拟发行票的数量。此值在有资金定额票下必填，有资金定额票下不能填写，单位为张。该数值必须是大于0的整数，最大票发行数量不能超过10,000,000。
        /// </summary>
        [JsonPropertyName("ticket_quantity")]
        public long TicketQuantity { get; set; }

        /// <summary>
        /// 票类型，取值范围为：  1. 定额有资金代金票：BALANCE_FIX_TICKET，在创建时需要传入票面额；  2. 不定额有资金代金票 BALANCE_RANDOM_TICKET，在票发放时传入票面额；
        /// </summary>
        [JsonPropertyName("ticket_type")]
        public string TicketType { get; set; }

        /// <summary>
        /// 票有效期。有两种类型：绝对时间和相对时间。使用JSON字符串表示。绝对时间有3个key：type、start、end，type取值固定为"ABSOLUTE"，start和end分别表示票生效时间和失效时间，格式为yyyy-MM-dd HH:mm:ss。绝对时间示例：{"type": "ABSOLUTE", "start": "2017-01-10 00:00:00", "end": "2017-01-13 23:59:59"}。相对时间有3个key：type、duration、unit，type取值固定为"RELATIVE"，duration表示从发票时间开始到往后推duration个单位时间为止作为票的使用有效期，unit表示有效时间单位，有效时间单位可枚举：MINUTE, HOUR, DAY。示例：{"type": "RELATIVE", "duration": 1 , "unit": "DAY" }，如果此刻发票，那么该票从现在开始生效1(duration)天(unit)后失效。有效期最多5年（一年按照365天计算，一共1825天），绝对时间限制按照当前系统时间计算可配日期（当前日期+1825天）
        /// </summary>
        [JsonPropertyName("ticket_valid_period")]
        public string TicketValidPeriod { get; set; }

        /// <summary>
        /// 票可发放总金额（仅用于有资金不定额票，有资金定额票不能填写此值）。币种为人民币，单位为元。该数值需大于等于1，小于等于1,000,000,000，小数点以后最多保留两位
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }
    }
}
