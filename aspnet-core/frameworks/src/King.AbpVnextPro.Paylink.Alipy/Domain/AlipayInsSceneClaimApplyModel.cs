﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayInsSceneClaimApplyModel Data Structure.
    /// </summary>
    public class AlipayInsSceneClaimApplyModel : AlipayObject
    {
        /// <summary>
        /// 出险地点
        /// </summary>
        [JsonPropertyName("accident_address")]
        public string AccidentAddress { get; set; }

        /// <summary>
        /// 出险描述
        /// </summary>
        [JsonPropertyName("accident_desc")]
        public string AccidentDesc { get; set; }

        /// <summary>
        /// 出险时间
        /// </summary>
        [JsonPropertyName("accident_time")]
        public string AccidentTime { get; set; }

        /// <summary>
        /// 受益人
        /// </summary>
        [JsonPropertyName("beneficiary")]
        public InsPerson Beneficiary { get; set; }

        /// <summary>
        /// 支付账单流水的标题
        /// </summary>
        [JsonPropertyName("bill_title")]
        public string BillTitle { get; set; }

        /// <summary>
        /// 理赔因子;标准json格式
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 索赔金额（如果需要外部指定则必填），单位分
        /// </summary>
        [JsonPropertyName("claim_fee")]
        public long ClaimFee { get; set; }

        /// <summary>
        /// 报案时相关的保单信息
        /// </summary>
        [JsonPropertyName("claim_policy_list")]
        public List<InsClaimPolicy> ClaimPolicyList { get; set; }

        /// <summary>
        /// 商户生成的外部投保业务单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户生成的理赔请求单号【幂等字段】
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 产品编码；由蚂蚁保险平台分配，商户通过该产品编码投保特定的保险产品（如饿了么外卖延误险）
        /// </summary>
        [JsonPropertyName("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 报案人
        /// </summary>
        [JsonPropertyName("reporter")]
        public InsPerson Reporter { get; set; }
    }
}
