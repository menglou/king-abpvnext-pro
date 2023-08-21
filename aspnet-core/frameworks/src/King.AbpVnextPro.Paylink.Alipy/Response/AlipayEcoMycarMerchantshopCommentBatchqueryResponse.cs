﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoMycarMerchantshopCommentBatchqueryResponse.
    /// </summary>
    public class AlipayEcoMycarMerchantshopCommentBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 评论信息
        /// </summary>
        [JsonPropertyName("comment_result")]
        public List<MerchantshopCommentResult> CommentResult { get; set; }

        /// <summary>
        /// 评论统计信息
        /// </summary>
        [JsonPropertyName("comment_statistic")]
        public MerchantshopCommentStatistic CommentStatistic { get; set; }
    }
}
