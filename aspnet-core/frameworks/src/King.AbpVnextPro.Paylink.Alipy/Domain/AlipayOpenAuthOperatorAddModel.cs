using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenAuthOperatorAddModel Data Structure.
    /// </summary>
    public class AlipayOpenAuthOperatorAddModel : AlipayObject
    {
        /// <summary>
        /// 添加蚂蚁操作员参数
        /// </summary>
        [JsonPropertyName("operator_add_vo")]
        public OperatorAddVO OperatorAddVo { get; set; }
    }
}
