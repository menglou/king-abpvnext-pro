using King.AbpVnextPro.Paylink.WeChat;
using King.AbpVnextPro.Paylink.WeChat.V3;
using King.AbpVnextPro.Paylink.WeChat.V3.Notify;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace King.AbpVnextPro.PayCenter.PayCenter
{
    [Authorize]
    [RemoteService(Name = "WeChatPayV3Notify")]
    [ControllerName("WeChatPayV3Notify")]
    [Area("WeChatPayV3Notify")]
    [Route("/api/wechatPay/V3/Notify")]
    public class WeChatPayV3NotifyController:PayCenterController
    {
        private readonly ILogger<WeChatPayV3NotifyController> _logger;
        private readonly IWeChatPayNotifyClient _client;
        private readonly IGetWeChatSettingService _getWeChatSettingService;
        private WeChatPayOptions options;
        public WeChatPayV3NotifyController(ILogger<WeChatPayV3NotifyController> logger, IWeChatPayNotifyClient client, IGetWeChatSettingService getWeChatSettingService)
        {
            _logger = logger;
            _client = client;
            _getWeChatSettingService = getWeChatSettingService;
            options = _getWeChatSettingService.GetWeChatSettingAsync().Result;
        }

        /// <summary>
        /// 支付结果通知
        /// </summary>
        [Route("transactions")]
        [HttpPost]
        public virtual async Task<IActionResult> Transactions()
        {
            try
            {
                var notify = await _client.ExecuteAsync<WeChatPayTransactionsNotify>(Request, options);
                if (notify.TradeState == WeChatPayTradeState.Success)
                {
                    _logger.LogInformation("支付结果通知 => OutTradeNo: " + notify.OutTradeNo);
                    return Ok(WeChatPayNotifyResult.Success);
                }

                return WeChatPayNotifyResult.Failure;
            }
            catch (WeChatPayException ex)
            {
                _logger.LogWarning("出现异常: " + ex.Message);
                return Ok(WeChatPayNotifyResult.Failure);
            }
        }

        /// <summary>
        /// 退款结果通知
        /// </summary>
        [Route("refund")]
        [HttpPost]
        public virtual async Task<IActionResult> Refund()
        {
            try
            {
                var notify = await _client.ExecuteAsync<WeChatPayRefundDomesticRefundsNotify>(Request, options);
                if (notify.RefundStatus == WeChatPayRefundStatus.Success)
                {
                    _logger.LogInformation("退款结果通知 => OutTradeNo: " + notify.OutTradeNo);
                    return WeChatPayNotifyResult.Success;
                }

                return WeChatPayNotifyResult.Failure;
            }
            catch (WeChatPayException ex)
            {
                _logger.LogWarning("出现异常: " + ex.Message);
                return WeChatPayNotifyResult.Failure;
            }
        }

        #region 微信支付分

        /// <summary>
        /// 开启/解除授权服务回调通知
        /// </summary>
        [Route("score/permissions")]
        [HttpPost]
        public virtual async Task<IActionResult> Permissions()
        {
            try
            {
                var notify = await _client.ExecuteAsync<WeChatPayScoreUserOpenOrCloseNotify>(Request, options);
                if (notify.UserServiceStatus == WeChatPayScoreUserServiceStatus.Opened ||
                    notify.UserServiceStatus == WeChatPayScoreUserServiceStatus.Closed)
                {
                    _logger.LogInformation("开启/解除授权服务回调通知 => " + notify.Body);
                    return WeChatPayNotifyResult.Success;
                }

                return WeChatPayNotifyResult.Failure;
            }
            catch (WeChatPayException ex)
            {
                _logger.LogWarning("出现异常: " + ex.Message);
                return WeChatPayNotifyResult.Failure;
            }
        }

        /// <summary>
        /// 确认订单回调通知
        /// </summary>
        [Route("score/orderconfirm")]
        [HttpPost]
        public virtual async Task<IActionResult> OrderConfirm()
        {
            try
            {
                var notify = await _client.ExecuteAsync<WeChatPayScoreUserConfirmNotify>(Request, options);
                if (notify.State == WeChatPayServiceOrderState.Doing)
                {
                    _logger.LogInformation("确认订单回调通知 => " + notify.Body);
                    return WeChatPayNotifyResult.Success;
                }

                return WeChatPayNotifyResult.Failure;
            }
            catch (WeChatPayException ex)
            {
                _logger.LogWarning("出现异常: " + ex.Message);
                return WeChatPayNotifyResult.Failure;
            }
        }

        /// <summary>
        /// 订单支付成功回调通知
        /// </summary>
        [Route("score/orderpaid")]
        [HttpPost]
        public virtual async Task<IActionResult> OrderPaid()
        {
            try
            {
                var notify = await _client.ExecuteAsync<WeChatPayScoreUserPaidNotify>(Request, options);
                if (notify.State == WeChatPayServiceOrderState.Done)
                {
                    _logger.LogInformation("订单支付成功回调通知 => " + notify.Body);
                    return WeChatPayNotifyResult.Success;
                }

                return WeChatPayNotifyResult.Failure;
            }
            catch (WeChatPayException ex)
            {
                _logger.LogWarning("出现异常: " + ex.Message);
                return WeChatPayNotifyResult.Failure;
            }
        }

        /// <summary>
        /// 订单确认 或 支付成功 回调通知
        /// </summary>
        [Route("score/confirmorpaid")]
        [HttpPost]
        public virtual async Task<IActionResult> OrderConfirmOrPaid()
        {
            try
            {
                var notify = await _client.ExecuteAsync<WeChatPayScoreUserPaidNotify>(Request, options);
                if (notify.State == WeChatPayServiceOrderState.Doing || notify.State == WeChatPayServiceOrderState.Done)
                {
                    _logger.LogInformation("订单确认或支付成功回调通知: " + notify.Body);
                    return WeChatPayNotifyResult.Success;
                }

                return WeChatPayNotifyResult.Failure;
            }
            catch (WeChatPayException ex)
            {
                _logger.LogWarning("出现异常: " + ex.Message);
                return WeChatPayNotifyResult.Failure;
            }
        }

        #endregion
    }
}
