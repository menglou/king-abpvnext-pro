using King.AbpVnextPro.Paylink.WeChat;
using King.AbpVnextPro.Paylink.WeChat.V2;
using King.AbpVnextPro.Paylink.WeChat.V2.Notify;
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
    [RemoteService(Name = "WeChatPayV2Notify")]
    [ControllerName("WeChatPayV2Notify")]
    [Area("WeChatPayV2Notify")]
    [Route("/api/wechatPay/V2/Notify")]
    public class WeChatPayV2NotifyController: PayCenterController
    {
        private readonly ILogger<WeChatPayV2NotifyController> _logger;
        private readonly IWeChatPayNotifyClient _client;
        private readonly IGetWeChatSettingService _getWeChatSettingService;
        private WeChatPayOptions options;
        public WeChatPayV2NotifyController(ILogger<WeChatPayV2NotifyController> logger, IWeChatPayNotifyClient client, IGetWeChatSettingService getWeChatSettingService)
        {
            _logger = logger;
            _client = client;
            _getWeChatSettingService = getWeChatSettingService;
            options = _getWeChatSettingService.GetWeChatSettingAsync().Result;
        }

        /// <summary>
        /// 统一下单支付结果通知
        /// </summary>
        [Route("unifiedorder")]
        [HttpPost]
        public virtual async Task<IActionResult> Unifiedorder()
        {
            try
            {
                var notify = await _client.ExecuteAsync<WeChatPayUnifiedOrderNotify>(Request, options);
                if (notify.ReturnCode == WeChatPayCode.Success)
                {
                    if (notify.ResultCode == WeChatPayCode.Success)
                    {
                        _logger.LogInformation("统一下单支付结果通知 => OutTradeNo: " + notify.OutTradeNo);
                        return Ok(WeChatPayNotifyResult.Success);
                    }
                }

                return Ok(WeChatPayNotifyResult.Failure);
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
                var notify = await _client.ExecuteAsync<WeChatPayRefundNotify>(Request, options);
                if (notify.ReturnCode == WeChatPayCode.Success)
                {
                    if (notify.RefundStatus == WeChatPayRefundStatus.Success)
                    {
                        _logger.LogInformation("退款结果通知 => OutTradeNo: " + notify.OutTradeNo);
                        return Ok(WeChatPayNotifyResult.Success);
                    }
                }

                return Ok(WeChatPayNotifyResult.Failure);
            }
            catch (WeChatPayException ex)
            {
                _logger.LogWarning("出现异常: " + ex.Message);
                return Ok(WeChatPayNotifyResult.Failure);
            }
        }
    }
}
