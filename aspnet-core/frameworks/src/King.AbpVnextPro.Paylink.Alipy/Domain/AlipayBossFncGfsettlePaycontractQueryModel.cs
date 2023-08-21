﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettlePaycontractQueryModel Data Structure.
    /// </summary>
    public class AlipayBossFncGfsettlePaycontractQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询条件
        /// </summary>
        [JsonPropertyName("pay_contract_base_dto")]
        public PayContractBaseDTO PayContractBaseDto { get; set; }
    }
}
