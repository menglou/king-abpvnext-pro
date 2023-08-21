﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenPublicTemplateMessageAddModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicTemplateMessageAddModel : AlipayObject
    {
        /// <summary>
        /// 自行组合模板关键词列表，关键词顺序按数组顺序，关键字名称不能重复，最多支持5个，最少2个关键词组合
        /// </summary>
        [JsonPropertyName("keyword_list")]
        public List<PublicMsgKeyword> KeywordList { get; set; }

        /// <summary>
        /// 消息母板id，登录 <a href="https://fuwu.alipay.com/platform/spa/merchant/main/index">生活号后台</a>，点击【消息与互动】菜单【模板消息】，即可看到/领取模板的消息母板id。
        /// </summary>
        [JsonPropertyName("lib_code")]
        public string LibCode { get; set; }

        /// <summary>
        /// 可选字段的选择，开头语(name=first)，结束语(name=remark)以及图片(name=image)。选择使用的话则在入参中name中标识，不选用任何可选字段可不传。
        /// </summary>
        [JsonPropertyName("opt_list")]
        public List<PublicMsgKeyword> OptList { get; set; }
    }
}
