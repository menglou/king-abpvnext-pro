﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayUserUserinfoShareResponse.
    /// </summary>
    public class AlipayUserUserinfoShareResponse : AlipayResponse
    {
        /// <summary>
        /// 详细地址。
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 区域编码，暂时不返回值
        /// </summary>
        [JsonPropertyName("address_code")]
        public string AddressCode { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 区县名称。
        /// </summary>
        [JsonPropertyName("area")]
        public string Area { get; set; }

        /// <summary>
        /// 用户头像
        /// </summary>
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 【注意】当is_balance_frozen为“F”时，改字段不会返回.  CTU ---- CTU冻结，允许用户开启  ALIBABA ---- ALIBABA冻结，允许用户开启  SERVER ---- 后台冻结，允许用户开启  USER ----  用户冻结   CTU_N---- CTU冻结，不允许用户开启  ALIBABA_N ---- ALIBABA冻结，不允许用户开启  SERVER_N ---- 后台冻结，不允许用户开启  UNKNOWN ---- 降级、或查询超时
        /// </summary>
        [JsonPropertyName("balance_freeze_type")]
        public string BalanceFreezeType { get; set; }

        /// <summary>
        /// 用户生日
        /// </summary>
        [JsonPropertyName("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 0:身份证  1:护照  2:军官证  3:士兵证  4:回乡证  5:临时身份证  6:户口簿  7:警官证  8:台胞证  9:营业执照  10其它证件
        /// </summary>
        [JsonPropertyName("cert_type_value")]
        public string CertTypeValue { get; set; }

        /// <summary>
        /// 市名称。
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 是否默认收货地址，暂时不返回值
        /// </summary>
        [JsonPropertyName("default_deliver_address")]
        public string DefaultDeliverAddress { get; set; }

        /// <summary>
        /// 收货人地址列表
        /// </summary>
        [JsonPropertyName("deliver_address_list")]
        public List<DeliverAddress> DeliverAddressList { get; set; }

        /// <summary>
        /// 收货人所在区县
        /// </summary>
        [JsonPropertyName("deliver_area")]
        public string DeliverArea { get; set; }

        /// <summary>
        /// 收货人所在城市
        /// </summary>
        [JsonPropertyName("deliver_city")]
        public string DeliverCity { get; set; }

        /// <summary>
        /// 收货人全称
        /// </summary>
        [JsonPropertyName("deliver_fullname")]
        public string DeliverFullname { get; set; }

        /// <summary>
        /// 收货地址的联系人移动电话。
        /// </summary>
        [JsonPropertyName("deliver_mobile")]
        public string DeliverMobile { get; set; }

        /// <summary>
        /// 收货地址的联系人固定电话。
        /// </summary>
        [JsonPropertyName("deliver_phone")]
        public string DeliverPhone { get; set; }

        /// <summary>
        /// 收货人所在省份
        /// </summary>
        [JsonPropertyName("deliver_province")]
        public string DeliverProvince { get; set; }

        /// <summary>
        /// 用户支付宝账号绑定的邮箱地址
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// 姓氏，取的是realName中的首个字符，对非中文、中文复姓支持较差。
        /// </summary>
        [JsonPropertyName("family_name")]
        public string FamilyName { get; set; }

        /// <summary>
        /// 公司名称（用户类型是公司类型时公司名称才有此字段）。
        /// </summary>
        [JsonPropertyName("firm_name")]
        public string FirmName { get; set; }

        /// <summary>
        /// 性别（F：女性；M：男性）
        /// </summary>
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// T--被冻结；F--未冻结
        /// </summary>
        [JsonPropertyName("is_balance_frozen")]
        public string IsBalanceFrozen { get; set; }

        /// <summary>
        /// T为是银行卡认证，F为非银行卡认证。
        /// </summary>
        [JsonPropertyName("is_bank_auth")]
        public string IsBankAuth { get; set; }

        /// <summary>
        /// 是否通过实名认证。T是通过 F是没有实名认证
        /// </summary>
        [JsonPropertyName("is_certified")]
        public string IsCertified { get; set; }

        /// <summary>
        /// T：表示A类实名认证；F：表示非A类实名认证
        /// </summary>
        [JsonPropertyName("is_certify_grade_a")]
        public string IsCertifyGradeA { get; set; }

        /// <summary>
        /// T为是身份证认证，F为非身份证认证。
        /// </summary>
        [JsonPropertyName("is_id_auth")]
        public string IsIdAuth { get; set; }

        /// <summary>
        /// T为通过营业执照认证，F为没有通过
        /// </summary>
        [JsonPropertyName("is_licence_auth")]
        public string IsLicenceAuth { get; set; }

        /// <summary>
        /// T为是手机认证，F为非手机认证。
        /// </summary>
        [JsonPropertyName("is_mobile_auth")]
        public string IsMobileAuth { get; set; }

        /// <summary>
        /// 是否是学生
        /// </summary>
        [JsonPropertyName("is_student_certified")]
        public string IsStudentCertified { get; set; }

        /// <summary>
        /// 手机号码。
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [JsonPropertyName("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 电话号码。
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 省份名称。
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }

        /// <summary>
        /// 用户的真实姓名。
        /// </summary>
        [JsonPropertyName("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 生日的月和日，MMdd格式
        /// </summary>
        [JsonPropertyName("reduced_birthday")]
        public string ReducedBirthday { get; set; }

        /// <summary>
        /// 用户的userId
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户状态（Q/T/B/W）。  Q代表快速注册用户  T代表已认证用户  B代表被冻结账户  W代表已注册，未激活的账户
        /// </summary>
        [JsonPropertyName("user_status")]
        public string UserStatus { get; set; }

        /// <summary>
        /// 用户类型（1/2）  1代表公司账户2代表个人账户
        /// </summary>
        [JsonPropertyName("user_type_value")]
        public string UserTypeValue { get; set; }

        /// <summary>
        /// 邮政编码。
        /// </summary>
        [JsonPropertyName("zip")]
        public string Zip { get; set; }
    }
}
