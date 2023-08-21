﻿using King.AbpVnextPro.Paylink.WeChat.V3.Response;

namespace King.AbpVnextPro.Paylink.WeChat.V3.Request
{
    /// <summary>
    /// 基础支付 - APP支付 - 统一下单
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_1.shtml">APP支付 - 统一下单API</a> - 最新更新时间：2020.05.26</para>
    /// </remarks>
    public class WeChatPayTransactionsAppRequest : IWeChatPayPostRequest<WeChatPayTransactionsAppResponse>
    {
        private WeChatPayObject bodyModel;

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/pay/transactions/app";
        }

        public WeChatPayObject GetBodyModel()
        {
            return bodyModel;
        }

        public void SetBodyModel(WeChatPayObject bodyModel)
        {
            this.bodyModel = bodyModel;
        }
    }
}
