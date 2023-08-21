﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayMarketingSharetokenCreateModel Data Structure.
    /// </summary>
    public class AlipayMarketingSharetokenCreateModel : AlipayObject
    {
        /// <summary>
        /// 业务标识，类似于业务主键，诸如pid、uid、门店id
        /// </summary>
        [JsonPropertyName("biz_linked_id")]
        public string BizLinkedId { get; set; }

        /// <summary>
        /// 吱口令的业务类型，新增业务请联系吱口令PD和开发分配
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 展示在吱口令解码面板上的左下方按钮，一般用作取消操作
        /// </summary>
        [JsonPropertyName("btn_left")]
        public string BtnLeft { get; set; }

        /// <summary>
        /// 吱口令解码面板上左下方按钮的连接。一般不建议传值，默认行为是关闭吱口令面板
        /// </summary>
        [JsonPropertyName("btn_left_href")]
        public string BtnLeftHref { get; set; }

        /// <summary>
        /// 吱口令解码面板上的右下方按钮文案
        /// </summary>
        [JsonPropertyName("btn_right")]
        public string BtnRight { get; set; }

        /// <summary>
        /// 吱口令解码面板上右下方按钮的链接、一般是活动页面或业务跳转地址
        /// </summary>
        [JsonPropertyName("btn_right_href")]
        public string BtnRightHref { get; set; }

        /// <summary>
        /// 展示在吱口令解码的面板上的描述文案
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 展示在吱口令解码面板上的图标。建议传入cdn的地址。
        /// </summary>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 启用时间，如果为空，则默认给接口调用时候系统的当前时间
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 吱口令的有效期
        /// </summary>
        [JsonPropertyName("timeout")]
        public long Timeout { get; set; }

        /// <summary>
        /// 展示在吱口令解码的面板上的标题字段
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
