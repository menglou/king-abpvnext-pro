﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MerchantCard Data Structure.
    /// </summary>
    public class MerchantCard : AlipayObject
    {
        /// <summary>
        /// 资金卡余额，单位：元，精确到小数点后两位。
        /// </summary>
        [JsonPropertyName("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 支付宝业务卡号  说明：  1、开卡成功后返回该参数，需要保存留用；  2、开卡/更新/删卡/查询卡接口请求中不需要传该参数；
        /// </summary>
        [JsonPropertyName("biz_card_no")]
        public string BizCardNo { get; set; }

        /// <summary>
        /// 商户外部会员卡卡号  说明：  1、会员卡开卡接口，如果卡类型为外部会员卡，请求中则必须提供该参数；  2、更新、查询、删除等接口，请求中则不需要提供该参数值；
        /// </summary>
        [JsonPropertyName("external_card_no")]
        public string ExternalCardNo { get; set; }

        /// <summary>
        /// 卡面展示图片的图片ID，通过接口（alipay.offline.material.image.upload）上传图片    这里预期展示的是个人照片；  图片说明：1M以内，格式bmp、png、jpeg、jpg、gif；  图片尺寸为230*295px，可等比放大；
        /// </summary>
        [JsonPropertyName("front_image_id")]
        public string FrontImageId { get; set; }

        /// <summary>
        /// 卡面文案列表，1项对应1行文案，最多只能传入4行文案；  单行文案展现分为左右两部分，左边对应label字段，右边对应value；  形如： 学院    新闻学院
        /// </summary>
        [JsonPropertyName("front_text_list")]
        public List<CardFrontTextDTO> FrontTextList { get; set; }

        /// <summary>
        /// 会员卡等级（由商户自定义，并可以在卡模板创建时，定义等级信息）
        /// </summary>
        [JsonPropertyName("level")]
        public string Level { get; set; }

        /// <summary>
        /// 商户动态码回传信息：  只用于当write_off_type核销类型为mdbarcode或mdqrcode时，商户调用卡更新接口回传动态码。如需使用商户动态码，请联系支付宝技术支持获取相关文档。
        /// </summary>
        [JsonPropertyName("mdcode_info")]
        public MdCodeInfoDTO MdcodeInfo { get; set; }

        /// <summary>
        /// 会员卡开卡时间，格式为yyyy-MM-dd HH:mm:ss。会员卡更新时，该时间不支持修改，请传入调用开卡接口时传入的card_ext_info.open_date时间。
        /// </summary>
        [JsonPropertyName("open_date")]
        public string OpenDate { get; set; }

        /// <summary>
        /// 会员卡积分，积分必须为数字型（可为浮点型，带2位小数点）
        /// </summary>
        [JsonPropertyName("point")]
        public string Point { get; set; }

        /// <summary>
        /// 会员卡更换不同的卡模板（该参数仅用在会员卡更新接口中）
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 会员卡有效期，格式为yyyy-MM-dd HH:mm:ss。会员卡更新时，该时间不支持修改，请传入调用开卡接口时传入的card_ext_info.valid_date时间。
        /// </summary>
        [JsonPropertyName("valid_date")]
        public string ValidDate { get; set; }
    }
}
