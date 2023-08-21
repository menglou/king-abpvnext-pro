using King.AbpVnextPro.Paylink.Alipy;
using King.AbpVnextPro.Paylink.Alipy.Notify;
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
    [RemoteService(Name = "AliPayReturn")]
    [ControllerName("AliPayReturn")]
    [Area("AliPayReturn")]
    [Route("/api/aliPay/Return")]
    public class AliPayReturnController : PayCenterController
    {
        private readonly ILogger<AliPayReturnController> _logger;
        private readonly IAlipayNotifyClient _client;
        private AlipayOptions options = new AlipayOptions();
        private readonly IGetAlipaySettingService _getAlipaySettingService;
        public AliPayReturnController(ILogger<AliPayReturnController> logger, IAlipayNotifyClient client, IGetAlipaySettingService getAlipaySettingService)
        {
            _logger = logger;
            _client = client;
            _getAlipaySettingService = getAlipaySettingService;
            options = _getAlipaySettingService.GetAlipaySettingAsync().Result;
        }

        /// <summary>
        /// 电脑网站支付 - 同步跳转
        /// </summary>
        [Route("pagepay")]
        [HttpGet]
        public async Task<IActionResult> PagePay()
        {
            try
            {
                var notify = await _client.ExecuteAsync<AlipayTradePagePayReturn>(Request, options);

                return Ok();
            }
            catch (AlipayException ex)
            {
                _logger.LogWarning("出现异常: " + ex.Message);

                return BadRequest();
            }
        }

        /// <summary>
        /// 手机网站支付 - 同步跳转
        /// </summary>
        [HttpGet]
        [Route("wappay")]
        public async Task<IActionResult> WapPay()
        {
            try
            {
                var notify = await _client.ExecuteAsync<AlipayTradeWapPayReturn>(Request, options);

                return Ok();
            }
            catch (AlipayException ex)
            {
                _logger.LogWarning("出现异常: " + ex.Message);
                return BadRequest();
            }
        }
    }
}
