﻿using System.Collections.Generic;
using King.AbpVnextPro.Paylink.WeChat.V2.Response;

namespace King.AbpVnextPro.Paylink.WeChat.V2.Request
{
    /// <summary>
    /// 小程序红包 - 发放普通红包 (普通商户 / 服务商)
    /// </summary>
    public class WeChatPaySendMiniProgramHbRequest : IWeChatPayCertRequest<WeChatPaySendMiniProgramHbResponse>
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        public string MchBillNo { get; set; }

        /// <summary>
        /// 触达用户appid
        /// </summary>
        public string MsgAppId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        public string SendName { get; set; }

        /// <summary>
        /// 用户openid
        /// </summary>
        public string ReOpenId { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        public int TotalAmount { get; set; }

        /// <summary>
        /// 红包发放总人数
        /// </summary>
        public int TotalNum { get; set; }

        /// <summary>
        /// 红包祝福语
        /// </summary>
        public string Wishing { get; set; }

        /// <summary>
        /// Ip地址
        /// </summary>
        public string ClientIp { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        public string ActName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 通知用户形式
        /// </summary>
        public string NotifyWay { get; set; }

        /// <summary>
        /// 场景id
        /// </summary>
        public string SceneId { get; set; }

        /// <summary>
        /// 活动信息
        /// </summary>
        public string RiskInfo { get; set; }

        #region IWeChatPayCertRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/mmpaymkttransfers/sendminiprogramhb";
        private WeChatPaySignType signType = WeChatPaySignType.MD5;

        public string GetRequestUrl()
        {
            return requestUrl;
        }

        public void SetRequestUrl(string url)
        {
            requestUrl = url;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "mch_billno", MchBillNo },
                { "msgappid", MsgAppId },
                { "send_name", SendName },
                { "re_openid", ReOpenId },
                { "total_amount", TotalAmount },
                { "total_num", TotalNum },
                { "wishing", Wishing },
                { "client_ip", ClientIp },
                { "act_name", ActName },
                { "remark", Remark },
                { "scene_id", SceneId },
                { "risk_info", RiskInfo },
            };
            return parameters;
        }

        public WeChatPaySignType GetSignType()
        {
            return signType;
        }

        public void SetSignType(WeChatPaySignType signType)
        {
            this.signType = signType switch
            {
                WeChatPaySignType.MD5 => signType,
                _ => throw new WeChatPayException("api only support MD5!"),
            };
        }

        public void PrimaryHandler(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options)
        {
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);
            sortedTxtParams.Add(WeChatPayConsts.sub_mch_id, options.SubMchId);

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.APIKey, signType));
        }

        public bool GetNeedCheckSign()
        {
            return false;
        }

        #endregion
    }
}
