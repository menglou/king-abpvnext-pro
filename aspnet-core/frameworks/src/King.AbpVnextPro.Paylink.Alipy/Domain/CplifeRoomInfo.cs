﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// CplifeRoomInfo Data Structure.
    /// </summary>
    public class CplifeRoomInfo : AlipayObject
    {
        /// <summary>
        /// 房间的完整门牌地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 房屋所在楼栋名称。例如“1栋”，“1幢”等
        /// </summary>
        [JsonPropertyName("building")]
        public string Building { get; set; }

        /// <summary>
        /// 房屋所在的组团名称。例如“一期”，“东区”，“香桂苑”等
        /// </summary>
        [JsonPropertyName("group")]
        public string Group { get; set; }

        /// <summary>
        /// 商户系统小区房屋唯一ID标示.
        /// </summary>
        [JsonPropertyName("out_room_id")]
        public string OutRoomId { get; set; }

        /// <summary>
        /// 房屋所在房号。例如“1101室”，“11B室”等
        /// </summary>
        [JsonPropertyName("room")]
        public string Room { get; set; }

        /// <summary>
        /// 房屋所在单元名称。例如“一单元”，“二单元”等
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }
}
