﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyInsturlQueryModel Data Structure.
    /// </summary>
    public class MybankCreditLoanapplyInsturlQueryModel : AlipayObject
    {
        /// <summary>
        /// 机构合约编号，商户接入企业信贷业务时自动分配，获取地址：https://partner.mybank.cn/cooperation/myCooperation.htm，路径：我的合作-查看详情-开发接口调用-接口合约编号；
        /// </summary>
        [JsonPropertyName("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 业务接入类型，取值：Dsd、Ptd；Dsd为大数据贷款类型（网商贷专业版、基础版接口包对应合作机构请选择此类型，即合作机构推送数据，网商计算授信，网商承担风险），Ptd为平台贷款类型（合作机构自行计算授信并承担风险）；
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 机构内部客户身份证号，当biz_type为Dsd时，cert_no +user_name或者user_id不能同时为null。作用：校验机构提供的用户和支付宝当前登录的用户为同一用户，即用户合法性校验。
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 机构客群标签，仅当arrangement_no存在的时候，此值可以为空；
        /// </summary>
        [JsonPropertyName("cust_group_code")]
        public string CustGroupCode { get; set; }

        /// <summary>
        /// 机构内部客户工商注册号；
        /// </summary>
        [JsonPropertyName("ext_business_license_no")]
        public string ExtBusinessLicenseNo { get; set; }

        /// <summary>
        /// 机构用户ID，机构须保证编号唯一；
        /// </summary>
        [JsonPropertyName("ext_user_id")]
        public string ExtUserId { get; set; }

        /// <summary>
        /// 机构内部客户手机号，如果没有，默认值为11位0；
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 运营产品编码，仅当arrangement_no存在的时候，此值可以为空；
        /// </summary>
        [JsonPropertyName("op_pd_code")]
        public string OpPdCode { get; set; }

        /// <summary>
        /// 入驻的机构的渠道编号，由业务接口人来分配
        /// </summary>
        [JsonPropertyName("org_channel_code")]
        public string OrgChannelCode { get; set; }

        /// <summary>
        /// 跳转链接的类型，取值：scheme、landing；scheme为支付宝扫码跳转链接，landing为外部App跳转链接；
        /// </summary>
        [JsonPropertyName("url_type")]
        public string UrlType { get; set; }

        /// <summary>
        /// 机构内部客户的支付宝ID，当biz_type为Dsd时，cert_no +user_name或者user_id不能同时为null。作用：校验机构提供的用户和支付宝当前登录的用户为同一用户，即用户合法性校验。
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 机构内部客户姓名，当biz_type为Dsd时，cert_no + user_name或者user_id不能同时为null。作用：校验机构提供的用户和支付宝当前登录的用户为同一用户，即用户合法性校验。
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
