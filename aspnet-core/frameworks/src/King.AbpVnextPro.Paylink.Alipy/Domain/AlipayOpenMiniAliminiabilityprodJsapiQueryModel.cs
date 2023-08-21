﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenMiniAliminiabilityprodJsapiQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniAliminiabilityprodJsapiQueryModel : AlipayObject
    {
        /// <summary>
        /// 来源端,高德:com.amap.app,IOT:com.alipay.iot.xpaas,微博:com.weibo.app,优酷:com.youku.app,网商银行:com.mybank.phone,菜鸟:com.cainiao.app,天猫精灵:com.alibaba.ailabs.genie.webapps,UC:com.uc.app,支付宝:com.alipay.alipaywallet,口碑:com.koubei.mobile.KoubeiClient,财富:com.alipay.antfortune,学习强国:com.xuexi.app,支付宝香港:com.alipay.wallethk
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 英文名称
        /// </summary>
        [JsonPropertyName("en_name")]
        public string EnName { get; set; }

        /// <summary>
        /// 交换中心接口版本
        /// </summary>
        [JsonPropertyName("instance_version")]
        public string InstanceVersion { get; set; }
    }
}
