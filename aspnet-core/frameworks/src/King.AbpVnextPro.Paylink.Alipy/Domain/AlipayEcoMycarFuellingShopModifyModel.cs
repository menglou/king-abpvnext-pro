﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEcoMycarFuellingShopModifyModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarFuellingShopModifyModel : AlipayObject
    {
        /// <summary>
        /// 门店地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 国标6位城市编号
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 国标6位区编号
        /// </summary>
        [JsonPropertyName("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 纬度，高德坐标系，最好找到高德POI标识，取得标识的维度填入
        /// </summary>
        [JsonPropertyName("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 经度，高德坐标系,最好找到高德POI标识，取得标识的经度填入
        /// </summary>
        [JsonPropertyName("lon")]
        public string Lon { get; set; }

        /// <summary>
        /// 外部门店编号系统唯一，该值添加后不可修改，与字段shop_id不能同时为空
        /// </summary>
        [JsonPropertyName("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// ISV提供的门店支付链接地址，如果支付链接地址为空，默认使用用户的当面付链接地址。注意：链接地址必须使用https://或alipays://协议。,需进行encode转码
        /// </summary>
        [JsonPropertyName("pay_url")]
        public string PayUrl { get; set; }

        /// <summary>
        /// 高德POI信息唯一ID，可通过http://lbs.amap.com/api/webservice/guide/api/search/ 进行查找，查询的TYPE为010100|010101|010102|010103|010104|010105|010107|010108|010109|010110|010111|010112
        /// </summary>
        [JsonPropertyName("poi_id")]
        public string PoiId { get; set; }

        /// <summary>
        /// 国标6位省份编号
        /// </summary>
        [JsonPropertyName("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 车主平台内部门店编号，系统唯一,与字段out_shop_id不能同
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店状态，0：有效；1：停用；
        /// </summary>
        [JsonPropertyName("shop_status")]
        public string ShopStatus { get; set; }
    }
}
