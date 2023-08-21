﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMerchantKbdeviceDevicesBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiMerchantKbdeviceDevicesBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 需要筛选的设备类型。目前仅支持 FOOD_DISPENSER （取餐柜）类型的设备查询，必须填写FOOD_DISPENSER。
        /// </summary>
        [JsonPropertyName("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
