﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayPayApplepayTransactionauthtokenDeleteModel Data Structure.
    /// </summary>
    public class AlipayPayApplepayTransactionauthtokenDeleteModel : AlipayObject
    {
        /// <summary>
        /// 设备id
        /// </summary>
        [JsonPropertyName("device_identifier")]
        public string DeviceIdentifier { get; set; }

        /// <summary>
        /// 卡id
        /// </summary>
        [JsonPropertyName("provisioning_bundle_identifier")]
        public string ProvisioningBundleIdentifier { get; set; }

        /// <summary>
        /// 卡id列表
        /// </summary>
        [JsonPropertyName("provisioning_bundle_identifiers")]
        public List<string> ProvisioningBundleIdentifiers { get; set; }

        /// <summary>
        /// 推送通知token
        /// </summary>
        [JsonPropertyName("push_token")]
        public string PushToken { get; set; }

        /// <summary>
        /// uid
        /// </summary>
        [JsonPropertyName("reference_identifier")]
        public string ReferenceIdentifier { get; set; }
    }
}
