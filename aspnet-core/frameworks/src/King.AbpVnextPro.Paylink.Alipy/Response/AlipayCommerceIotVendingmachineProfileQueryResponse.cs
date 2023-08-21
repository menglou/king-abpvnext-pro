using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceIotVendingmachineProfileQueryResponse.
    /// </summary>
    public class AlipayCommerceIotVendingmachineProfileQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 消费者画像列表
        /// </summary>
        [JsonPropertyName("consumer_profile_list")]
        public List<ConsumerProfile> ConsumerProfileList { get; set; }

        /// <summary>
        /// 附近人群密度
        /// </summary>
        [JsonPropertyName("nearby_crowd_density_list")]
        public List<NearbyCrowdDensity> NearbyCrowdDensityList { get; set; }

        /// <summary>
        /// 推荐商品列表
        /// </summary>
        [JsonPropertyName("recommend_goods_list")]
        public List<RecommendGoods> RecommendGoodsList { get; set; }

        /// <summary>
        /// 货柜销售数据统计
        /// </summary>
        [JsonPropertyName("sales_data_list")]
        public List<SalesData> SalesDataList { get; set; }
    }
}
