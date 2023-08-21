using King.AbpVnextPro.PayCenter.PayCenter.AliPay;
using King.AbpVnextPro.Paylink.Alipy;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace King.AbpVnextPro.PayCenter.PayCenter
{
    [Authorize]
    [RemoteService(Name = "AliPay")]
    [ControllerName("AliPay")]
    [Area("AliPay")]
    [Route("/api/aliPay")]
    public class AliPayController:PayCenterController,IAliPayAppService
    {
        private readonly IAliPayAppService  _aliPayAppService;
        private ILogger<AliPayController> _logger;
        public AliPayController(ILogger<AliPayController> logger, IAliPayAppService aliPayAppService)
        {
            _logger = logger;
            _aliPayAppService = aliPayAppService;
        }
        [HttpPost]
        [Route("accountQuery")]
        public virtual Task<AccountQueryDto> AccountQueryAsync(AlipayAccountQueryViewModel viewModel)
        {
            return _aliPayAppService.AccountQueryAsync(viewModel);
        }
        [HttpPost]
        [Route("appPay")]
        public virtual Task<AppPayDto> AppPayAsync(AlipayTradeAppPayViewModel viewModel)
        {
            return _aliPayAppService.AppPayAsync(viewModel);
        }
        [HttpPost]
        [Route("close")]
        public virtual Task<CloseDto> CloseAsync(AlipayTradeCloseViewModel viewModel)
        {
            return _aliPayAppService.CloseAsync(viewModel);
        }
        [HttpPost]
        [Route("pagePay")]
        public virtual Task<PagePayDto> PagePayAsync(AlipayTradePagePayViewModel viewModel)
        {
            return _aliPayAppService.PagePayAsync(viewModel);
        }
        [HttpPost]
        [Route("pay")]
        public virtual Task<PayDto> PayAsync(AlipayTradePayViewModel viewModel)
        {
            return _aliPayAppService.PayAsync(viewModel);
        }
        [HttpPost]
        [Route("preCreate")]
        public virtual Task<PreCreateDto> PreCreateAsync(AlipayTradePreCreateViewModel viewModel)
        {
            return _aliPayAppService.PreCreateAsync(viewModel);
        }
        [HttpPost]
        [Route("query")]
        public virtual Task<QueryDto> QueryAsyc(AlipayTradeQueryViewModel viewModel)
        {
            return _aliPayAppService.QueryAsyc(viewModel);
        }
        [HttpPost]
        [Route("refund")]
        public virtual Task<RefundDto> RefundAsync(AlipayTradeRefundViewModel viewModel)
        {
            return _aliPayAppService.RefundAsync(viewModel);
        }
        [HttpPost]
        [Route("refundQuery")]
        public virtual Task<RefundQueryDto> RefundQueryAsync(AlipayTradeRefundQueryViewModel viewModel)
        {
            return _aliPayAppService.RefundQueryAsync(viewModel);
        }
        [HttpPost]
        [Route("transfer")]
        public virtual Task<TransferDto> TransferAsync(AlipayTransferViewModel viewModel)
        {
            return _aliPayAppService.TransferAsync(viewModel);
        }
        [HttpPost]
        [Route("transferQuery")]
        public virtual Task<TransQueryDto> TransQueryAsync(AlipayTransQueryViewModel viewModel)
        {
            return _aliPayAppService.TransQueryAsync(viewModel);
        }
        [HttpPost]
        [Route("wapPay")]
        public virtual Task<WapPayDto> WapPayAsync(AlipayTradeWapPayViewModel viewModel)
        {
            return _aliPayAppService.WapPayAsync(viewModel);
        }
    }
}
