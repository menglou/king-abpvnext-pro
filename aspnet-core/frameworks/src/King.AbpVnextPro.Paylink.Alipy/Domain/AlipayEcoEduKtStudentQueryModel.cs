﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEcoEduKtStudentQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoEduKtStudentQueryModel : AlipayObject
    {
        /// <summary>
        /// 已经签约教育缴费的isv的支付宝PID
        /// </summary>
        [JsonPropertyName("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 学校编号，调用alipay.eco.edu.kt.schoolinfo.modify接口录入学校信息时，接口返回的编号
        /// </summary>
        [JsonPropertyName("school_no")]
        public string SchoolNo { get; set; }

        /// <summary>
        /// 学校用来签约支付宝教育缴费的支付宝PID
        /// </summary>
        [JsonPropertyName("school_pid")]
        public string SchoolPid { get; set; }

        /// <summary>
        /// 通过alipay.eco.edu.kt.billing.send发送教育缴费账单时，支付宝返回这个student_no,如果支付宝系统中还没有这个学生，则会根据学生的属性，创建一个全局唯一的学生缴费账号并返回。
        /// </summary>
        [JsonPropertyName("student_no")]
        public string StudentNo { get; set; }
    }
}
