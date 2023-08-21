﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiCateringDishMaterialQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishMaterialQueryModel : AlipayObject
    {
        /// <summary>
        /// 口碑内部加料id，若不为空，则为单条查询，page_size和page_no失效；如果为空，则为批量查询，page_size和page_no必传，否则为默认值
        /// </summary>
        [JsonPropertyName("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 要查询的加料库的商户id
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// isv的外部加料id，和口碑内部加料id二选一，都不为空时以内部加料id为优先；若不为空，则为单条查询，page_size和page_no失效；如果都为空，则为批量查询，page_size和page_no必传，否则为默认值
        /// </summary>
        [JsonPropertyName("out_material_id")]
        public string OutMaterialId { get; set; }

        /// <summary>
        /// 查询页码，表示第几页；兼顾老版本，批量查询不传时默认为1
        /// </summary>
        [JsonPropertyName("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小，表示每页查询数量，不超过200；兼容老版本，批量查询不传时默认为200
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }
    }
}
