﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvMachinegoodsAddModel Data Structure.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvMachinegoodsAddModel : AlipayObject
    {
        /// <summary>
        /// 当前请求选取商品算法Id
        /// </summary>
        [JsonPropertyName("algorithm_goods_id")]
        public string AlgorithmGoodsId { get; set; }

        /// <summary>
        /// 商品摆放姿态
        /// </summary>
        [JsonPropertyName("display_mode")]
        public string DisplayMode { get; set; }

        /// <summary>
        /// 柜内已有商品摆放状态
        /// </summary>
        [JsonPropertyName("exist_goods_state")]
        public List<GoodsState> ExistGoodsState { get; set; }

        /// <summary>
        /// 货柜层数
        /// </summary>
        [JsonPropertyName("floor_num")]
        public long FloorNum { get; set; }

        /// <summary>
        /// 货柜型号
        /// </summary>
        [JsonPropertyName("machine_type_id")]
        public string MachineTypeId { get; set; }
    }
}
