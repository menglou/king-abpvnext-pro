﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayDataDataserviceDatabusSendModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceDatabusSendModel : AlipayObject
    {
        /// <summary>
        /// 对应于adatabus这边的eventCode纬度，databus这边是通过topic+eventCode纬度来找到对应的数据源，用于适配databus这边的数据源模型，可以参考主站消息中心的topic和eventCode的命名方式。
        /// </summary>
        [JsonPropertyName("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// 传给adatabus的消息体，约定为json格式
        /// </summary>
        [JsonPropertyName("event_payload")]
        public string EventPayload { get; set; }

        /// <summary>
        /// event_payload的类型，消息到了databus之后，会把event_payload的json串根据本参数转换成特定的类型。如果没有提供此参数，默认是转换成Map结构。    需要注意的是，这个类需要在adatabus中能找到，并且和当前的json串是匹配的，如果adatabus这边没有这个类，可以通过业务jar的方式在adatabus中注册
        /// </summary>
        [JsonPropertyName("payload_class")]
        public string PayloadClass { get; set; }

        /// <summary>
        /// 对应于adatabus这边的topic纬度，databus这边是通过topic+eventCode纬度来找到对应的数据源，用于适配databus这边的数据源模型，可以参考主站消息中心的topic和eventCode的命名方式。
        /// </summary>
        [JsonPropertyName("topic")]
        public string Topic { get; set; }
    }
}
