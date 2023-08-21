﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayMerchantIotDeviceBindModel Data Structure.
    /// </summary>
    public class AlipayMerchantIotDeviceBindModel : AlipayObject
    {
        /// <summary>
        /// 设备 ID ，仅device_id_type 为 ID 时填写。
        /// </summary>
        [JsonPropertyName("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 可选方式。枚举支持： *  ID：表示使用 biztid 作为设备唯一识别标识， *  SN：表示使用 supplier_id、device_sn联合作为设备唯一识别标识。 注意：由于不同机型的supplier_id不同，推荐使用 ID 。
        /// </summary>
        [JsonPropertyName("device_id_type")]
        public string DeviceIdType { get; set; }

        /// <summary>
        /// 设备序列号 ，device_id_type 为 SN 时填写。需配合supplier_id使用。
        /// </summary>
        [JsonPropertyName("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 商户类型。枚举支持： *  direct：直连商户； *  indirect：间连商户。
        /// </summary>
        [JsonPropertyName("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 直连场景填写商户收单pid。间连场景填写smid绑定的pid（可通过代运营授权API获取）。
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 商户pid名下的门店 ID。可通过门店管理API获取，需注意请勿使用smid创建门店 ID。
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 直连场景不填，间连场景填写商户收单smid
        /// </summary>
        [JsonPropertyName("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 设备供应商ID ，device_id_type 为 SN 时填写。需注意不同机型的供应商ID可能不同。
        /// </summary>
        [JsonPropertyName("supplier_id")]
        public string SupplierId { get; set; }
    }
}
