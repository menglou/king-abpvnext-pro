﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenCategoryArticleQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenCategoryArticleQueryModel : AlipayObject
    {
        /// <summary>
        /// ID  类目名称  WEB001  运动迷  WEB002  娱乐  WEB003  游戏  WEB004  看大片  WEB005  爱美丽  WEB006  车参考  WEB007  星座  WEB008  养娃经  WEB009  美食家  WEB010  玩出游  WEB011  科技圈  WEB012  潮数码  WEB013  财知道  WEB014  彩票  WEB016  职场  WEB999  其他
        /// </summary>
        [JsonPropertyName("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
