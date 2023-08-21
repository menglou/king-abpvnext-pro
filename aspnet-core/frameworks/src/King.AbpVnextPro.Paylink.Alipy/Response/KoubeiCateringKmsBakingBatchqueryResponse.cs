using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringKmsBakingBatchqueryResponse.
    /// </summary>
    public class KoubeiCateringKmsBakingBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 烘焙商品销量预测
        /// </summary>
        [JsonPropertyName("baking_sales_forecast_data")]
        public List<KmsBakingSalesForecastDTO> BakingSalesForecastData { get; set; }
    }
}
