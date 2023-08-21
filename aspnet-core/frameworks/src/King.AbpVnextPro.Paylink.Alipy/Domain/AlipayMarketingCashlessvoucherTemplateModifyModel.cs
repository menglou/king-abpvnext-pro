﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayMarketingCashlessvoucherTemplateModifyModel Data Structure.
    /// </summary>
    public class AlipayMarketingCashlessvoucherTemplateModifyModel : AlipayObject
    {
        /// <summary>
        /// 模板修改操作外部业务号，用于修改时的幂等控制，注意这里不是修改业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 发放结束时间，晚于该时间不能发券。券的发放结束时间和发放开始时间跨度不能大于90天。发放结束时间必须晚于发放开始时间。格式为：yyyy-MM-dd HH:mm:ss。 仅支持延长发券时间，不支持提前结束。即仅支持传入比创建券模板时发券结束时间晚的时间点。
        /// </summary>
        [JsonPropertyName("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 规则配置，仅需传入增加规则，不传默认创建时规则。JSON字符串，{"PID": "2088512417841101,2088512417841102", "STORE": "123456,678901"}，其中PID表示可以核销该券的pid列表，多个值用英文逗号隔开，STORE表示可以核销该券的内部门店ID，多个值用英文逗号隔开，不传此参数则不修改规则，仅支持新增规则，若有要修改规则那么必须包含PID，规则修改仅支持代金券。
        /// </summary>
        [JsonPropertyName("rule_conf")]
        public string RuleConf { get; set; }

        /// <summary>
        /// 券模板ID ，参数值可通过调用<a href="https://opendocs.alipay.com/apis/009zu9">alipay.marketing.cashlessvoucher.template.create</a>（无资金券模板创建接口）创建券模板获取。
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
