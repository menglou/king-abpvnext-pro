﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ZhimaCreditEpSceneFulfillmentSyncModel Data Structure.
    /// </summary>
    public class ZhimaCreditEpSceneFulfillmentSyncModel : AlipayObject
    {
        /// <summary>
        /// 特定业务场景传输的扩展参数，以JSON形式传输。具体业务场景需要传入参数请参考<a href="https://docs.open.alipay.com/11270#s3">业务场景传输的扩展参数</a>
        /// </summary>
        [JsonPropertyName("biz_ext_param")]
        public string BizExtParam { get; set; }

        /// <summary>
        /// 业务时间，日期格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 信用订单号，为<a href="https://opendocs.alipay.com/apis/api_8/zhima.credit.ep.scene.agreement.use">zhima.credit.ep.scene.agreement.use</a>接口加入信用服务后获取的credit_order_no（信用订单号）。
        /// </summary>
        [JsonPropertyName("credit_order_no")]
        public string CreditOrderNo { get; set; }

        /// <summary>
        /// 商户请求订单号，必须唯一。用于唯一标识商户的一笔履约调用。
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
