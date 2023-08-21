﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// InvoiceSendOpenModel Data Structure.
    /// </summary>
    public class InvoiceSendOpenModel : AlipayObject
    {
        /// <summary>
        /// 支付宝端的申请id。如果在开票过程中，是通过支付宝提交的申请到机构端，支付宝会带上开票申请在支付宝生成的申请id，机构在回传发票的时候只需要回传这个申请id，不用获取用户的uid，支付宝可以根据申请id将发票归集到对应的用户名下
        /// </summary>
        [JsonPropertyName("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 票面上的校验码信息。
        /// </summary>
        [JsonPropertyName("check_code")]
        public string CheckCode { get; set; }

        /// <summary>
        /// 票面上复核人信息。
        /// </summary>
        [JsonPropertyName("checker")]
        public string Checker { get; set; }

        /// <summary>
        /// 票面上开票员信息。
        /// </summary>
        [JsonPropertyName("clerk")]
        public string Clerk { get; set; }

        /// <summary>
        /// 不含税金额，票面上的不含税金额，单位（元），保留两位小数。
        /// </summary>
        [JsonPropertyName("ex_tax_amount")]
        public string ExTaxAmount { get; set; }

        /// <summary>
        /// 预留的扩展字段，格式如：key1=value1\nkey2=value2\nkey3=value3，字段之间以\n分隔。
        /// </summary>
        [JsonPropertyName("extend_fields")]
        public string ExtendFields { get; set; }

        /// <summary>
        /// 下载版式文件类型，需要回传文件下载链接的情况下必传， 取值范围：PDF，JPG，OFD
        /// </summary>
        [JsonPropertyName("file_download_type")]
        public string FileDownloadType { get; set; }

        /// <summary>
        /// 发票版式文件下载地址。
        /// </summary>
        [JsonPropertyName("file_download_url")]
        public string FileDownloadUrl { get; set; }

        /// <summary>
        /// 财政电子票据子类型，当tax_type=FINANCIAL_ELECTRONIC_BILL时要求必填 可选值如下： 01:非税收入通用票据 02:非税收入专用票据 03:非税收入一般缴款书 04:资金往来结算票据 05:公益事业捐赠票据 06:医疗收费票据 07:社会团体会费票据 08:社会保险基金票据 09:工会经费收入票据 99:其他财政票据
        /// </summary>
        [JsonPropertyName("financial_electronic_type")]
        public string FinancialElectronicType { get; set; }

        /// <summary>
        /// 发票代码，该字段与invoice_no构成一张发票的唯一标识。
        /// </summary>
        [JsonPropertyName("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票明细项。
        /// </summary>
        [JsonPropertyName("invoice_content")]
        public List<InvoiceItemOpenModel> InvoiceContent { get; set; }

        /// <summary>
        /// 开票日期，格式如：YYYY-MM-DD。
        /// </summary>
        [JsonPropertyName("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 标识发票的类型， PLAIN:增值税电子普通发票; SPECIAL:增值税专用发票; PLAIN_INVOICE:增值税普通发票; FINANCIAL_ELECTRONIC_BILL:财政电子票据;
        /// </summary>
        [JsonPropertyName("invoice_kind")]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 票面上备注信息。
        /// </summary>
        [JsonPropertyName("invoice_memo")]
        public string InvoiceMemo { get; set; }

        /// <summary>
        /// 发票号码，该字段与invoice_code构成一张发票的唯一标识。
        /// </summary>
        [JsonPropertyName("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票抬头，票面上的购买方信息。
        /// </summary>
        [JsonPropertyName("invoice_title")]
        public InvoiceTitleOpenModel InvoiceTitle { get; set; }

        /// <summary>
        /// 标识是红票还是蓝票，RED:红票;BLUE:蓝票。
        /// </summary>
        [JsonPropertyName("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 红票情况下，必须填入原始蓝票的发票代码。
        /// </summary>
        [JsonPropertyName("ori_blue_inv_code")]
        public string OriBlueInvCode { get; set; }

        /// <summary>
        /// 红票情况下，必须填入原始蓝票的发票号码。
        /// </summary>
        [JsonPropertyName("ori_blue_inv_no")]
        public string OriBlueInvNo { get; set; }

        /// <summary>
        /// 外部发票id，isv生成发票之后所生成的发票流水号，主要用做存储。
        /// </summary>
        [JsonPropertyName("out_invoice_id")]
        public string OutInvoiceId { get; set; }

        /// <summary>
        /// 该发票基于的实际交易流水号。
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 票面上收款人信息。
        /// </summary>
        [JsonPropertyName("payee")]
        public string Payee { get; set; }

        /// <summary>
        /// 票面上销售方地址、电话信息。
        /// </summary>
        [JsonPropertyName("payee_address_tel")]
        public string PayeeAddressTel { get; set; }

        /// <summary>
        /// 票面上销售方开户行及账号。
        /// </summary>
        [JsonPropertyName("payee_bank_name_account")]
        public string PayeeBankNameAccount { get; set; }

        /// <summary>
        /// 票面上销售方企业名称。
        /// </summary>
        [JsonPropertyName("payee_register_name")]
        public string PayeeRegisterName { get; set; }

        /// <summary>
        /// 票面上销售方税号信息。
        /// </summary>
        [JsonPropertyName("payee_register_no")]
        public string PayeeRegisterNo { get; set; }

        /// <summary>
        /// 价税合计，票面上的总开票金额，单位（元），保留两位小数，sum_amount=ex_tax_amount+tax_amount。
        /// </summary>
        [JsonPropertyName("sum_amount")]
        public string SumAmount { get; set; }

        /// <summary>
        /// 合计税额，票面上的合计税额，单位（元），保留两位小数。
        /// </summary>
        [JsonPropertyName("tax_amount")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 交易内容，非必填但是不可以传空值，如果无需回传trade_list则不需要传该对象
        /// </summary>
        [JsonPropertyName("trade_list")]
        public List<EinvTrade> TradeList { get; set; }

        /// <summary>
        /// 支付宝用户userId，当发送红字发票时，即invoice_type＝RED时，可选填；或者apply_id不为空的时候，可选填；其他情况必填。
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
