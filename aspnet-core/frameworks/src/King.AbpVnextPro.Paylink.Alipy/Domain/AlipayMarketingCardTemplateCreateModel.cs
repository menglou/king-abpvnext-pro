﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayMarketingCardTemplateCreateModel Data Structure.
    /// </summary>
    public class AlipayMarketingCardTemplateCreateModel : AlipayObject
    {
        /// <summary>
        /// 业务卡号前缀，由商户指定  支付宝业务卡号生成规则：biz_no_prefix(商户指定)卡号前缀 + biz_no_suffix(实时生成）卡号后缀
        /// </summary>
        [JsonPropertyName("biz_no_prefix")]
        public string BizNoPrefix { get; set; }

        /// <summary>
        /// 业务卡号后缀的长度，取值范围为[8,32]  支付宝业务卡号生成规则：biz_no_prefix(商户指定)卡号前缀 + biz_no_suffix(实时生成）卡号后缀  由于业务卡号最长不超过32位，所以biz_no_suffix_len <= 32 - biz_no_prefix的位数。注：biz_no_suffix_len一旦指定，在模板修改时不支持修改。
        /// </summary>
        [JsonPropertyName("biz_no_suffix_len")]
        public string BizNoSuffixLen { get; set; }

        /// <summary>
        /// 卡行动点配置； 行动点，即用户可点击跳转的区块，类似按钮控件的交互； 单张卡最多定制3个行动点。如果各项的配置内容完全一样，展示时会进行去重。
        /// </summary>
        [JsonPropertyName("card_action_list")]
        public List<TemplateActionInfoDTO> CardActionList { get; set; }

        /// <summary>
        /// 卡级别配置
        /// </summary>
        [JsonPropertyName("card_level_conf")]
        public List<TemplateCardLevelConfDTO> CardLevelConf { get; set; }

        /// <summary>
        /// 卡特定标签，只供特定业务使用，通常接入无需关注
        /// </summary>
        [JsonPropertyName("card_spec_tag")]
        public string CardSpecTag { get; set; }

        /// <summary>
        /// 卡类型。可选类型如下： OUT_MEMBER_CARD：外部权益卡
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 栏位信息
        /// </summary>
        [JsonPropertyName("column_info_list")]
        public List<TemplateColumnInfoDTO> ColumnInfoList { get; set; }

        /// <summary>
        /// 字段规则列表，会员卡开卡过程中，会员卡信息的生成规则，  例如：卡有效期为开卡后两年内有效，则设置为：DATE_IN_FUTURE
        /// </summary>
        [JsonPropertyName("field_rule_list")]
        public List<TemplateFieldRuleDTO> FieldRuleList { get; set; }

        /// <summary>
        /// 商户动态码通知参数配置：  当write_off_type指定为商户动态码mdbarcode或mdqrcode时必填；  在此字段配置用户打开会员卡时支付宝通知商户生成动态码（发码）的通知参数，如接收通知地址等。
        /// </summary>
        [JsonPropertyName("mdcode_notify_conf")]
        public TemplateMdcodeNotifyConfDTO MdcodeNotifyConf { get; set; }

        /// <summary>
        /// 会员卡用户领卡配置，在门店等渠道露出领卡入口时，需要部署的商户领卡H5页面地址
        /// </summary>
        [JsonPropertyName("open_card_conf")]
        public TemplateOpenCardConfDTO OpenCardConf { get; set; }

        /// <summary>
        /// 卡模板投放渠道
        /// </summary>
        [JsonPropertyName("pub_channels")]
        public List<PubChannelDTO> PubChannels { get; set; }

        /// <summary>
        /// 请求ID，商家自定义且并保证唯一性。
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 服务Code  HUABEI_FUWU：花呗服务（只有需要花呗服务时，才需要加入该标识）
        /// </summary>
        [JsonPropertyName("service_label_list")]
        public List<string> ServiceLabelList { get; set; }

        /// <summary>
        /// 会员卡上架门店id（支付宝门店id），即发放会员卡的商家门店id
        /// </summary>
        [JsonPropertyName("shop_ids")]
        public List<string> ShopIds { get; set; }

        /// <summary>
        /// 权益信息，  1、在卡包的卡详情页面会自动添加“会员权益”栏位，展现此字段配置的会员卡权益信息，  2、如果添加门店渠道，则可在门店页展现会员卡的权益
        /// </summary>
        [JsonPropertyName("template_benefit_info")]
        public List<TemplateBenefitInfoDTO> TemplateBenefitInfo { get; set; }

        /// <summary>
        /// 模板样式信息
        /// </summary>
        [JsonPropertyName("template_style_info")]
        public TemplateStyleInfoDTO TemplateStyleInfo { get; set; }

        /// <summary>
        /// 卡包详情页面中展现出的卡码（可用于扫码核销）    (1) 静态码  qrcode: 二维码，扫码得商户开卡传入的external_card_no  barcode: 条形码，扫码得商户开卡传入的external_card_no    (2) 动态码-支付宝生成码值(动态码会在2分钟左右后过期)  dqrcode: 动态二维码，扫码得到的码值可配合会员卡查询接口使用  dbarcode: 动态条形码，扫码得到的码值可配合会员卡查询接口使用    (3) 动态码-商家自主生成码值（码值、时效性都由商户控制）  mdqrcode: 商户动态二维码，扫码得商户自主传入的码值  mdbarcode: 商户动态条码，扫码得商户自主传入的码值  如需使用商户动态码，请联系支付宝技术支持获取相关文档。
        /// </summary>
        [JsonPropertyName("write_off_type")]
        public string WriteOffType { get; set; }
    }
}
