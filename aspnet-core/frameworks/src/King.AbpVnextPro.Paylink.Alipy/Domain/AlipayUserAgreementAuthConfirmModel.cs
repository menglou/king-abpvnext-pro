﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserAgreementAuthConfirmModel Data Structure.
    /// </summary>
    public class AlipayUserAgreementAuthConfirmModel : AlipayObject
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号。
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 鉴权申请token，其格式和内容，由支付宝定义。在该接口中，商户可根据申请操作成功时返回的申请token，进行鉴权确认操作。
        /// </summary>
        [JsonPropertyName("apply_token")]
        public string ApplyToken { get; set; }

        /// <summary>
        /// 鉴权确认码
        /// </summary>
        [JsonPropertyName("auth_confirm_no")]
        public string AuthConfirmNo { get; set; }
    }
}
