﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MedicalHospitalDeptInfo Data Structure.
    /// </summary>
    public class MedicalHospitalDeptInfo : AlipayObject
    {
        /// <summary>
        /// 科室唯一标识，编码开发者生成并保证唯一
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 科室位置
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// 科室名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父科室名称 如果是顶层科室可空 目的定位科室级联关系
        /// </summary>
        [JsonPropertyName("parent_name")]
        public string ParentName { get; set; }

        /// <summary>
        /// 父科室唯一标识  如果是顶层科室可空  目的定位科室级联关系
        /// </summary>
        [JsonPropertyName("partner_code")]
        public string PartnerCode { get; set; }
    }
}
