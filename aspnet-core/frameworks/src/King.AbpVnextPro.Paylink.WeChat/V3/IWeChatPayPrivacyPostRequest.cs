﻿namespace King.AbpVnextPro.Paylink.WeChat.V3
{
    /// <summary>
    /// WeChatPay V3 Post敏感信息请求接口
    /// </summary>
    /// <typeparam name="T">请求响应对象</typeparam>
    public interface IWeChatPayPrivacyPostRequest<T> where T : WeChatPayResponse
    {
        /// <summary>
        /// 获取请求接口地址
        /// </summary>
        /// <returns>接口地址</returns>
        string GetRequestUrl();

        /// <summary>
        /// 获取JSON参数模型
        /// </summary>
        /// <returns>JSON参数模型</returns>
        WeChatPayObject GetBodyModel();

        /// <summary>
        /// 设置JSON参数模型
        /// </summary>
        /// <param name="bodyModel">JSON参数模型</param>
        void SetBodyModel(WeChatPayObject bodyModel);
    }
}
