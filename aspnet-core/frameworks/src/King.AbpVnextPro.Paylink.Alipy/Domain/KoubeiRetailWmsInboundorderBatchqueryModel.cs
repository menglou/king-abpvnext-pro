﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiRetailWmsInboundorderBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiRetailWmsInboundorderBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 入库通知单id列表（外部业务单号列表二选一，不能同时传两个列表）
        /// </summary>
        [JsonPropertyName("inbound_order_id_list")]
        public List<string> InboundOrderIdList { get; set; }

        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonPropertyName("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 外部业务单号列表（入库通知单id列表二选一，不能同时传两个列表）
        /// </summary>
        [JsonPropertyName("out_biz_no_list")]
        public List<string> OutBizNoList { get; set; }
    }
}
