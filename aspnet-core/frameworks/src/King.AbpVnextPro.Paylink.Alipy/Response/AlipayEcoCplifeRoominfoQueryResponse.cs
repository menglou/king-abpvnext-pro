﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoCplifeRoominfoQueryResponse.
    /// </summary>
    public class AlipayEcoCplifeRoominfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 符合条件的小区房屋信息列表.
        /// </summary>
        [JsonPropertyName("room_info")]
        public List<CplifeRoomDetail> RoomInfo { get; set; }

        /// <summary>
        /// 该小区下已上传的房间总数
        /// </summary>
        [JsonPropertyName("total_room_number")]
        public long TotalRoomNumber { get; set; }
    }
}
