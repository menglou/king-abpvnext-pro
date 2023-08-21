﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiCateringDishDictionaryQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishDictionaryQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务字典类型.  定义如下: catetory 分类 ;unit 单位;spec 规格；virtual_category 虚拟类目。
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 字典的数据id
        /// </summary>
        [JsonPropertyName("dictionary_id")]
        public string DictionaryId { get; set; }

        /// <summary>
        /// 字典的扩展json，根据不同的biz_type,设置商家的自定义字典表key以及value。如果字典类型为catetory,  key为cateSort，cateType，level,parentCatetoryId（level传数字，cateType为dish或cook） ;如果字典类型为spec, key为specSort.。注意：如果是字符串拼接的方式，转移符\要替换为\\\ 。
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商户的支付宝user_id. 商户授权后,isv能获得
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// open 启动 stop 停用
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
