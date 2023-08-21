﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AntMerchantExpandMerchantStorelistQueryModel Data Structure.
    /// </summary>
    public class AntMerchantExpandMerchantStorelistQueryModel : AlipayObject
    {
        /// <summary>
        /// 可选：  true / false 。  当is_include_cognate = true ， 指定pid为空， 查询商户下所有pid的店铺  当is_include_cognate = true ，指定pid不为空时，查询指定pid的店铺  当is_include_cognate = false ，指定pid为空时，   查询当前商pid的店铺  当is_include_cognate = false ，指定pid不为空时，查询指定pid的店铺
        /// </summary>
        [JsonPropertyName("is_include_cognate")]
        public string IsIncludeCognate { get; set; }

        /// <summary>
        /// 页码，必须为大于0的整数， 1表示第一页，2表示第2页，依次类推。
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录条数，必须为大于0的整数，最大值为30
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 指定的商户pid，如果指定， 只返回此pid的店铺信息。(此pid必须是商户自己的)
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
    }
}
