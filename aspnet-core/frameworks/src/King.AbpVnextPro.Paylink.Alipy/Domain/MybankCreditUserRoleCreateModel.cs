﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MybankCreditUserRoleCreateModel Data Structure.
    /// </summary>
    public class MybankCreditUserRoleCreateModel : AlipayObject
    {
        /// <summary>
        /// 客户身份编码-个人是身份证号码、企业是工商注册号、会员是会员编号-具体的数字编号
        /// </summary>
        [JsonPropertyName("entity_code")]
        public string EntityCode { get; set; }

        /// <summary>
        /// 客户身份标识-个人是姓名、企业是公司名称、会员是会员名称，如支付宝的手机号或者邮箱号
        /// </summary>
        [JsonPropertyName("entity_name")]
        public string EntityName { get; set; }

        /// <summary>
        /// 客户身份类型-个人是PERSON、企业是COMPAY、会员是具体的站点如ALIPAY或者MYBANK
        /// </summary>
        [JsonPropertyName("entity_type")]
        public string EntityType { get; set; }

        /// <summary>
        /// 扩展数据（map转换为json字符串）
        /// </summary>
        [JsonPropertyName("ext_data")]
        public string ExtData { get; set; }

        /// <summary>
        /// 业务场景，7-代表网商贷在开放平台对外开放
        /// </summary>
        [JsonPropertyName("scene_type")]
        public string SceneType { get; set; }
    }
}
