using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsSceneInsassetprodPetprofilelistQueryResponse.
    /// </summary>
    public class AlipayInsSceneInsassetprodPetprofilelistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 列表
        /// </summary>
        [JsonPropertyName("pet_profiles")]
        public List<PetProfiles> PetProfiles { get; set; }
    }
}
