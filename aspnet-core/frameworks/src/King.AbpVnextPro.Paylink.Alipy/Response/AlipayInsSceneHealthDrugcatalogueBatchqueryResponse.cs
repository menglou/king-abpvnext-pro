using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsSceneHealthDrugcatalogueBatchqueryResponse.
    /// </summary>
    public class AlipayInsSceneHealthDrugcatalogueBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 药品列表
        /// </summary>
        [JsonPropertyName("drug_item_list")]
        public List<HealthDrugCatalogueItem> DrugItemList { get; set; }
    }
}
