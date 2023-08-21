﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingCardidQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarParkingCardidQueryModel : AlipayObject
    {
        /// <summary>
        /// 如果商户订单号为空，停车场id和车牌号不能为空，商户订单号优先查询
        /// </summary>
        [JsonPropertyName("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 用户支付成功而设备商状态没一起同步过来，手动执行查询
        /// </summary>
        [JsonPropertyName("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 查询订单时间（不传值为当日时间），格式"yyyy-MM-dd"
        /// </summary>
        [JsonPropertyName("sel_time")]
        public string SelTime { get; set; }

        /// <summary>
        /// 车主平台交易号，不能跟停车场编号和车牌号同时为空
        /// </summary>
        [JsonPropertyName("transaction_no")]
        public string TransactionNo { get; set; }
    }
}
