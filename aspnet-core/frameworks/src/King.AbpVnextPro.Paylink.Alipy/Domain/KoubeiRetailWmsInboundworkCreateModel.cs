﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiRetailWmsInboundworkCreateModel Data Structure.
    /// </summary>
    public class KoubeiRetailWmsInboundworkCreateModel : AlipayObject
    {
        /// <summary>
        /// 扩展字段，json格式
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 该作业关联的入库/出库通知单id
        /// </summary>
        [JsonPropertyName("notice_order_id")]
        public string NoticeOrderId { get; set; }

        /// <summary>
        /// 操作上下文
        /// </summary>
        [JsonPropertyName("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 与作业相关的外部单据号，如菜鸟发货id
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 入库作业明细列表
        /// </summary>
        [JsonPropertyName("work_details")]
        public List<WorkDetail> WorkDetails { get; set; }
    }
}
