using King.AbpVnextPro.Paylink.Alipy;
using King.AbpVnextPro.Paylink.Alipy.Notify;
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
    [RemoteService(Name = "AlipayNotify")]
    [ControllerName("AlipayNotify")]
    [Area("AlipayNotify")]
    [Route("/api/aliPay/Notify")]
    public class AliPayNotifyController:PayCenterController
    {
        private readonly ILogger<AliPayNotifyController> _logger;
        private readonly IAlipayNotifyClient _client;
        private readonly AlipayOptions options;
        private readonly IGetAlipaySettingService _getAlipaySettingService;

        public AliPayNotifyController(ILogger<AliPayNotifyController> logger, IAlipayNotifyClient client, IGetAlipaySettingService getAlipaySettingService)
        {
            _logger = logger;
            _client = client;
            _getAlipaySettingService = getAlipaySettingService;
            options = _getAlipaySettingService.GetAlipaySettingAsync().Result;
        }

        /// <summary>
        /// 应用网关
        /// </summary>
        /// <returns></returns>
        [Route("gateway")]
        [HttpPost]
        public virtual async Task<IActionResult> Gateway()
        {
            try
            {
                var msg_method = Request.Form["msg_method"].ToString();
                switch (msg_method)
                {
                    // 资金单据状态变更通知
                    case "alipay.fund.trans.order.changed":
                        {
                            var notify = await _client.CertificateExecuteAsync<AlipayFundTransOrderChangedNotify>(Request, options);
                            return Ok(Ok(AlipayNotifyResult.Success));
                        }
                    // 第三方应用授权取消消息
                    case "alipay.open.auth.appauth.cancelled":
                        {
                            var notify = await _client.CertificateExecuteAsync<AlipayOpenAuthAppauthCancelledNotify>(Request, options);
                            return Ok(Ok(AlipayNotifyResult.Success));
                        }
                    // 用户授权取消消息
                    case "alipay.open.auth.userauth.cancelled":
                        {
                            var notify = await _client.CertificateExecuteAsync<AlipayOpenAuthUserauthCancelledNotify>(Request, options);
                            return Ok(Ok(AlipayNotifyResult.Success));
                        }
                    // 小程序审核通过通知
                    case "alipay.open.mini.version.audit.passed":
                        {
                            var notify = await _client.CertificateExecuteAsync<AlipayOpenMiniVersionAuditPassedNotify>(Request, options);
                            return Ok(Ok(AlipayNotifyResult.Success));
                        }
                    // 小程序审核驳回通知
                    case "alipay.open.mini.version.audit.rejected":
                        {
                            var notify = await _client.CertificateExecuteAsync<AlipayOpenMiniVersionAuditRejectedNotify>(Request, options);
                            return Ok(Ok(AlipayNotifyResult.Success));
                        }
                    // 收单退款冲退完成通知
                    case "alipay.trade.refund.depositback.completed":
                        {
                            var notify = await _client.CertificateExecuteAsync<AlipayTradeRefundDepositbackCompletedNotify>(Request, options);
                            return Ok(Ok(AlipayNotifyResult.Success));
                        }
                    // 收单资金结算到银行账户，结算退票的异步通知
                    case "alipay.trade.settle.dishonoured":
                        {
                            var notify = await _client.CertificateExecuteAsync<AlipayTradeSettleDishonouredNotify>(Request, options);
                            return Ok(Ok(AlipayNotifyResult.Success));
                        }
                    // 收单资金结算到银行账户，结算失败的异步通知
                    case "alipay.trade.settle.fail":
                        {
                            var notify = await _client.CertificateExecuteAsync<AlipayTradeSettleFailNotify>(Request, options);
                            return Ok(Ok(AlipayNotifyResult.Success));
                        }
                    // 收单资金结算到银行账户，结算成功的异步通知
                    case "alipay.trade.settle.success":
                        {
                            var notify = await _client.CertificateExecuteAsync<AlipayTradeSettleSuccessNotify>(Request, options);
                            return Ok(Ok(AlipayNotifyResult.Success));
                        }
                    // 身份认证记录消息
                    case "alipay.user.certify.open.notify.completed":
                        {
                            var notify = await _client.CertificateExecuteAsync<AlipayUserCertifyOpenNotifyCompletedNotify>(Request, options);
                            return Ok(Ok(AlipayNotifyResult.Success));
                        }
                    default:
                        return Ok(Ok(AlipayNotifyResult.Failure));
                }
            }
            catch (AlipayException ex)
            {
                _logger.LogWarning("出现异常: " + ex.Message);
                return Ok(Ok(AlipayNotifyResult.Failure));
            }
        }

        /// <summary>
        /// 扫码支付异步通知
        /// </summary>
        [Route("precreate")]
        [HttpPost]
        public virtual async Task<IActionResult> Precreate()
        {
            try
            {
                var notify = await _client.CertificateExecuteAsync<AlipayTradePrecreateNotify>(Request, options);
                switch (notify.TradeStatus)
                {
                    case AlipayTradeStatus.Wait: // 等待付款
                        _logger.LogInformation("扫码支付异步通知-等待买家付款 => OutTradeNo: " + notify.OutTradeNo);
                        return Ok(Ok(AlipayNotifyResult.Success));
                    case AlipayTradeStatus.Success: // 支付成功
                        _logger.LogInformation("扫码支付异步通知-交易支付成功 => OutTradeNo: " + notify.OutTradeNo);
                        return Ok(Ok(AlipayNotifyResult.Success));
                    default:
                        return Ok(Ok(AlipayNotifyResult.Failure));
                }
            }
            catch (AlipayException ex)
            {
                _logger.LogWarning("出现异常: " + ex.Message);
                return Ok(Ok(AlipayNotifyResult.Failure));
            }
        }

        /// <summary>
        /// APP支付异步通知
        /// </summary>
        [Route("apppay")]
        [HttpPost]
        public virtual async Task<IActionResult> AppPay()
        {
            try
            {
                var notify = await _client.CertificateExecuteAsync<AlipayTradeAppPayNotify>(Request, options);
                switch (notify.TradeStatus)
                {
                    case AlipayTradeStatus.Success: // 支付成功
                        _logger.LogInformation("APP支付异步通知-交易支付成功 => OutTradeNo: " + notify.OutTradeNo);
                        return Ok(AlipayNotifyResult.Success);
                    case AlipayTradeStatus.Closed: // 交易关闭
                        _logger.LogInformation("APP支付异步通知-未付款交易超时关闭，或支付完成后全额退款 => OutTradeNo: " + notify.OutTradeNo);
                        return Ok(AlipayNotifyResult.Success);
                    case AlipayTradeStatus.Finished: // 交易完结
                        _logger.LogInformation("APP支付异步通知-交易结束，不可退款 => OutTradeNo: " + notify.OutTradeNo);
                        return Ok(AlipayNotifyResult.Success);
                    default:
                        return Ok(AlipayNotifyResult.Failure);
                }
            }
            catch (AlipayException ex)
            {
                _logger.LogWarning("出现异常: " + ex.Message);
                return Ok(AlipayNotifyResult.Failure);
            }
        }

        /// <summary>
        /// 电脑网站支付异步通知
        /// </summary>
        [Route("pagepay")]
        [HttpPost]
        public virtual async Task<IActionResult> PagePay()
        {
            try
            {
                var notify = await _client.CertificateExecuteAsync<AlipayTradePagePayNotify>(Request, options);
                switch (notify.TradeStatus)
                {
                    case AlipayTradeStatus.Success: // 支付成功
                        _logger.LogInformation("电脑网站支付异步通知-交易支付成功 => OutTradeNo: " + notify.OutTradeNo);
                        return Ok(AlipayNotifyResult.Success);
                    case AlipayTradeStatus.Closed: // 交易关闭
                        _logger.LogInformation("电脑网站支付异步通知-未付款交易超时关闭，或支付完成后全额退款 => OutTradeNo: " + notify.OutTradeNo);
                        return Ok(AlipayNotifyResult.Success);
                    case AlipayTradeStatus.Finished: // 交易完结
                        _logger.LogInformation("电脑网站支付异步通知-交易结束，不可退款 => OutTradeNo: " + notify.OutTradeNo);
                        return Ok(AlipayNotifyResult.Success);
                    default:
                        return Ok(AlipayNotifyResult.Failure);
                }
            }
            catch (AlipayException ex)
            {
                _logger.LogWarning("出现异常: " + ex.Message);
                return Ok(AlipayNotifyResult.Failure);
            }
        }

        /// <summary>
        /// 手机网站支付异步通知
        /// </summary>
        [Route("wappay")]
        [HttpPost]
        public virtual async Task<IActionResult> WapPay()
        {
            try
            {
                var notify = await _client.CertificateExecuteAsync<AlipayTradeWapPayNotify>(Request, options);
                switch (notify.TradeStatus)
                {
                    case AlipayTradeStatus.Success: // 支付成功
                        _logger.LogInformation("手机网站支付异步通知-交易支付成功 => OutTradeNo: " + notify.OutTradeNo);
                        return Ok(AlipayNotifyResult.Success);
                    case AlipayTradeStatus.Closed: // 交易关闭
                        _logger.LogInformation("手机网站支付异步通知-未付款交易超时关闭，或支付完成后全额退款 => OutTradeNo: " + notify.OutTradeNo);
                        return Ok(AlipayNotifyResult.Success);
                    case AlipayTradeStatus.Finished: // 交易完结
                        _logger.LogInformation("手机网站支付异步通知-交易结束，不可退款 => OutTradeNo: " + notify.OutTradeNo);
                        return Ok(AlipayNotifyResult.Success);
                    default:
                        return Ok(AlipayNotifyResult.Failure);
                }
            }
            catch (AlipayException ex)
            {
                _logger.LogWarning("出现异常: " + ex.Message);
                return Ok(AlipayNotifyResult.Failure);
            }
        }

        /// <summary>
        /// 交易关闭异步通知
        /// </summary>
        [Route("close")]
        [HttpPost]
        public virtual async Task<IActionResult> Close()
        {
            try
            {
                var notify = await _client.CertificateExecuteAsync<AlipayTradeCloseNotify>(Request, options);
                if (notify.TradeStatus == AlipayTradeStatus.Closed)
                {
                    _logger.LogInformation("交易关闭异步通知 => OutTradeNo: " + notify.OutTradeNo);

                    return Ok(AlipayNotifyResult.Success);
                }

                return Ok(AlipayNotifyResult.Failure);
            }
            catch (AlipayException ex)
            {
                _logger.LogWarning("出现异常: " + ex.Message);
                return Ok(AlipayNotifyResult.Failure);
            }
        }
    }
}
