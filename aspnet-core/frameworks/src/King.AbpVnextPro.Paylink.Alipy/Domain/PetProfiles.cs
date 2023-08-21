﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// PetProfiles Data Structure.
    /// </summary>
    public class PetProfiles : AlipayObject
    {
        /// <summary>
        /// 宠物档案列表
        /// </summary>
        [JsonPropertyName("pet_profile_list")]
        public List<PetProfile> PetProfileList { get; set; }

        /// <summary>
        /// 宠物类型，如猫、狗
        /// </summary>
        [JsonPropertyName("pet_type")]
        public string PetType { get; set; }
    }
}
