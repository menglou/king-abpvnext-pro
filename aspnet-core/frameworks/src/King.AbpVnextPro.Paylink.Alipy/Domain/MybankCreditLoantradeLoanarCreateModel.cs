﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MybankCreditLoantradeLoanarCreateModel Data Structure.
    /// </summary>
    public class MybankCreditLoantradeLoanarCreateModel : AlipayObject
    {
        /// <summary>
        /// 收款账号外标  对于支付宝账户，支付宝loginId；  对于网商银行账户，是虚拟卡号；  对于外部银行卡，是银行卡号
        /// </summary>
        [JsonPropertyName("account_ext_no")]
        public string AccountExtNo { get; set; }

        /// <summary>
        /// 收款方参与机构码，当收款账户为网商银行或外部银行时填充，即银行联行号（总行）
        /// </summary>
        [JsonPropertyName("account_fin_code")]
        public string AccountFinCode { get; set; }

        /// <summary>
        /// 收款方机构名称
        /// </summary>
        [JsonPropertyName("account_fin_name")]
        public string AccountFinName { get; set; }

        /// <summary>
        /// 帐户类别，对公/对私，枚举值如下：  1：对私   2：对公
        /// </summary>
        [JsonPropertyName("account_fin_type")]
        public string AccountFinType { get; set; }

        /// <summary>
        /// 收款方名称
        /// </summary>
        [JsonPropertyName("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 收款方账户号  对于支付宝账户，是支付宝会员id；  对于网商银行账户，是资金账号id；  对于外部银行卡，是银行卡号
        /// </summary>
        [JsonPropertyName("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 收款方账户类型，枚举值有：  ALIPAY（支付宝）  MY_BANK（网商银行）  OUT_BANK（外部银行）
        /// </summary>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 本次发起支用的客户支付宝会员id，客户登录系统后由外部机构传入
        /// </summary>
        [JsonPropertyName("alipay_id")]
        public string AlipayId { get; set; }

        /// <summary>
        /// 支用金额，默认人民币，精确到小数点两位，单位元
        /// </summary>
        [JsonPropertyName("apply_amt")]
        public string ApplyAmt { get; set; }

        /// <summary>
        /// 外部业务单据号，在外部机构上发生的交易编号，如在菜鸟供销平台上发生的采购单的业务编号
        /// </summary>
        [JsonPropertyName("bsn_no")]
        public string BsnNo { get; set; }

        /// <summary>
        /// 此字段主要是为了兼容新老逻辑，原来的签约并放款是由bkloanfront自己做了两阶段提交事务一致性处理，后面统一交给bkloantrade系统，如果为NEW则代表走bkloantrade去签约并放款，为空或者其他则保持原来逻辑不变
        /// </summary>
        [JsonPropertyName("bsn_type")]
        public string BsnType { get; set; }

        /// <summary>
        /// 本次支用的授信编号，网商银行审批通过后回传给外部机构，然后由外部机构传入
        /// </summary>
        [JsonPropertyName("credit_no")]
        public string CreditNo { get; set; }

        /// <summary>
        /// 客户群体，由网商银行事先分配给客户机构
        /// </summary>
        [JsonPropertyName("cust_group")]
        public string CustGroup { get; set; }

        /// <summary>
        /// 放款账户渠道，从贷款方案查询接口获取  DEFAULT_ALIPAY 默认支付宝  ASSIGNED_ACCOUNT 定向支付账户  MYBANK_ACCOUNT 网商银行二类户
        /// </summary>
        [JsonPropertyName("grant_channel")]
        public string GrantChannel { get; set; }

        /// <summary>
        /// 经营行业，枚举值如下：  F5199：零售  H6190：餐饮住宿  L7299：商业服务
        /// </summary>
        [JsonPropertyName("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 网商银行参与者id，外部机构调用创建网商会员接口获取，参见接口：mybank.credit.user.role.create
        /// </summary>
        [JsonPropertyName("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 网商银行参与者会员角色ID，外部机构调用创建网商会员接口获取，参见接口：mybank.credit.user.role.create
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 本次支用的授信对应的BC政策码，由网商银行事先分配给外部机构
        /// </summary>
        [JsonPropertyName("loan_policy_code")]
        public string LoanPolicyCode { get; set; }

        /// <summary>
        /// 贷款期限
        /// </summary>
        [JsonPropertyName("loan_term")]
        public long LoanTerm { get; set; }

        /// <summary>
        /// 贷款期限单位，枚举值：  Y：年  M：月  D：日
        /// </summary>
        [JsonPropertyName("loan_term_unit")]
        public string LoanTermUnit { get; set; }

        /// <summary>
        /// 是否需要校验同名账户，默认是校验
        /// </summary>
        [JsonPropertyName("need_check_account_same_name")]
        public bool NeedCheckAccountSameName { get; set; }

        /// <summary>
        /// 是否需要签署合同，默认是签署
        /// </summary>
        [JsonPropertyName("need_sign_contract")]
        public bool NeedSignContract { get; set; }

        /// <summary>
        /// 客户签约的销售产品编码，由网商银行事先分配给外部机构
        /// </summary>
        [JsonPropertyName("pd_code")]
        public string PdCode { get; set; }

        /// <summary>
        /// 客户签约的销售产品版本号，通过调用完整贷款方案（mybank.credit.loantrade.loanscheme.full.query）查询接口获取
        /// </summary>
        [JsonPropertyName("pd_version")]
        public string PdVersion { get; set; }

        /// <summary>
        /// 放款用的营销工具ID列表，例如打折卡ID列表
        /// </summary>
        [JsonPropertyName("promo_tools")]
        public List<string> PromoTools { get; set; }

        /// <summary>
        /// 还款账户
        /// </summary>
        [JsonPropertyName("repay_account")]
        public MyBkAccountVO RepayAccount { get; set; }

        /// <summary>
        /// 还款方式，枚举值如下：  1：等额本息  2：等额本金  3：按期付息到期还本  4：组合还款  6：一次性到期还本付息  7：固定利息等额分期
        /// </summary>
        [JsonPropertyName("repay_mode")]
        public string RepayMode { get; set; }

        /// <summary>
        /// 单次请求唯一流水号，用于幂等控制  结构为：客户机构ipRoleId_时间（日期、时分秒）_外部系统流水号
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 签名值
        /// </summary>
        [JsonPropertyName("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 交易备注
        /// </summary>
        [JsonPropertyName("trans_memo")]
        public string TransMemo { get; set; }
    }
}
