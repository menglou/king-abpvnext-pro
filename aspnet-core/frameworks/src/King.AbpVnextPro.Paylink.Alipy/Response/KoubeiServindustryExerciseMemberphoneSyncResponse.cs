using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiServindustryExerciseMemberphoneSyncResponse.
    /// </summary>
    public class KoubeiServindustryExerciseMemberphoneSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 健身用户手机号与健身用户id映射
        /// </summary>
        [JsonPropertyName("mapping_list")]
        public List<ExerciseUserMappingDTO> MappingList { get; set; }
    }
}
