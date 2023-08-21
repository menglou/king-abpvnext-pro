﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEbppMerchantExternalbillCreateModel Data Structure.
    /// </summary>
    public class AlipayEbppMerchantExternalbillCreateModel : AlipayObject
    {
        /// <summary>
        /// 账期金额,单位元
        /// </summary>
        [JsonPropertyName("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 账期描述
        /// </summary>
        [JsonPropertyName("bill_date_desc")]
        public string BillDateDesc { get; set; }

        /// <summary>
        /// 账期结束时间
        /// </summary>
        [JsonPropertyName("bill_date_end")]
        public string BillDateEnd { get; set; }

        /// <summary>
        /// 账期起始时间
        /// </summary>
        [JsonPropertyName("bill_date_start")]
        public string BillDateStart { get; set; }

        /// <summary>
        /// 主业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 账单过期时间, 可为空, 默认2099年
        /// </summary>
        [JsonPropertyName("expiry_date")]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// PROPERTY_MNG/物业费， PROPERTY_WATER/代收水费， PROPERTY_ELECTRIC/代收电费， PROPERTY_SHARE/公共维护金， PROPERTY_PARK_MNG/车位管理费， PROPERTY_PARK_LEASE /车位租赁费， PROPERTY_ROOM_LEASE/房屋租赁费， PROPERTY_TEMP_PARK/临时停车费， PROPERTY_PUBLIC_ENERGY/公共能耗费， PROPERTY_GAS/代收燃气费， PROPERTY_MAINTENANCE/维修服务费， PROPERTY_HOUSEKEEPING/家政服务费， PROPERTY_GREENING/绿化服务费， PROPERTY_STORAGE_ROOM/储藏室物业费， PROPERTY_DECORATION_DEPOSIT/装修押金， PROPERTY_REFUSE_COLLECTION/垃圾清运费， PROPERTY_PAID_SERVICE/有偿服务费， PROPERTY_WATER_SHARING/水费公摊费， PROPERTY_ELECTRIC_SHARING/电费公摊费, PROPERTY_DECORATION_MANAGEMENT/装修管理费, PROPERTY_HEATING_FEE/代收取暖费。
        /// </summary>
        [JsonPropertyName("fee_type")]
        public string FeeType { get; set; }

        /// <summary>
        /// 滞纳金, 单位元
        /// </summary>
        [JsonPropertyName("fine_amount")]
        public string FineAmount { get; set; }

        /// <summary>
        /// 滞纳金产生时间, 空代表不会出现滞纳金
        /// </summary>
        [JsonPropertyName("fine_date")]
        public string FineDate { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 缴费商户短码
        /// </summary>
        [JsonPropertyName("merchant_code")]
        public string MerchantCode { get; set; }

        /// <summary>
        /// 缴费实体ID
        /// </summary>
        [JsonPropertyName("object_id")]
        public string ObjectId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 账单生效时间, 空默认当前时间
        /// </summary>
        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; }

        /// <summary>
        /// 该账单是否用户可选 ，1 可选 0不可选，默认不可选
        /// </summary>
        [JsonPropertyName("select_optional")]
        public string SelectOptional { get; set; }

        /// <summary>
        /// 账单排列顺序
        /// </summary>
        [JsonPropertyName("sequence")]
        public long Sequence { get; set; }

        /// <summary>
        /// 服务费, 单位元
        /// </summary>
        [JsonPropertyName("service_amount")]
        public string ServiceAmount { get; set; }

        /// <summary>
        /// 子业务类型
        /// </summary>
        [JsonPropertyName("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 账单总金额,单位 元
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }
    }
}
