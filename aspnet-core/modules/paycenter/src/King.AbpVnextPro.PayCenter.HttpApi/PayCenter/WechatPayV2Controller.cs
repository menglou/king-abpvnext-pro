using King.AbpVnextPro.PayCenter.PayCenter.WeChat.V2;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace King.AbpVnextPro.PayCenter.PayCenter
{
    [Authorize]
    [RemoteService(Name = "WechatPayV2")]
    [ControllerName("WechatPayV2")]
    [Area("WechatPayV2")]
    [Route("/api/wechatPay/V2")]
    public class WechatPayV2Controller : PayCenterController, IWechatPayV2AppService
    {
        private IWechatPayV2AppService _wechatPayV2AppService;
        public WechatPayV2Controller(IWechatPayV2AppService wechatPayV2AppService)
        {
            _wechatPayV2AppService = wechatPayV2AppService;
        }
        [HttpPost]
        [Route("appPay")]
        public virtual  Task<AppPayDto> AppPayAsync(WeChatPayAppPayViewModel viewModel)
        {
            return  _wechatPayV2AppService.AppPayAsync(viewModel);
        }
        [HttpPost]
        [Route("closeOrder")]
        public virtual Task<CloseOrderDto> CloseOrderAsync(WeChatPayCloseOrderViewModel viewModel)
        {
            return  _wechatPayV2AppService.CloseOrderAsync(viewModel);
        }
        [HttpPost]
        [Route("downloadBill")]
        public virtual Task<DownloadBillDto> DownloadBillAsync(WeChatPayDownloadBillViewModel viewModel)
        {
            return  _wechatPayV2AppService.DownloadBillAsync(viewModel);
        }
        [HttpPost]
        [Route("downloadBillFlow")]
        public virtual Task<DownloadFundFlowDto> DownloadFundFlowAsync(WeChatPayDownloadFundFlowViewModel viewModel)
        {
            return  _wechatPayV2AppService.DownloadFundFlowAsync(viewModel);
        }
        [HttpPost]
        [Route("getPublishKey")]
        public virtual Task<GetPublicKeyDto> GetPublicKeyAsync()
        {
            return  _wechatPayV2AppService.GetPublicKeyAsync();
        }
        [HttpPost]
        [Route("getTransferInfo")]
        public virtual Task<GetTransferInfoDto> GetTransferInfoAsync(WeChatPayGetTransferInfoViewModel viewModel)
        {
            return  _wechatPayV2AppService.GetTransferInfoAsync(viewModel);
        }
        [HttpPost]
        [Route("h5Pay")]
        public virtual Task<H5PayDto> H5PayAsync(WeChatPayH5PayViewModel viewModel)
        {
            return  _wechatPayV2AppService.H5PayAsync(viewModel);
        }
        [HttpPost]
        [Route("microPay")]
        public virtual Task<MicroPayDto> MicroPayAsync(WeChatPayMicroPayViewModel viewModel)
        {
            return  _wechatPayV2AppService.MicroPayAsync(viewModel);
        }
        [HttpPost]
        [Route("miniProgramPay")]
        public virtual Task<MiniProgramPayDto> MiniProgramPayAsync(WeChatPayMiniProgramPayViewModel viewModel)
        {
            return  _wechatPayV2AppService.MiniProgramPayAsync(viewModel);
        }
        [HttpPost]
        [Route("orderQuery")]
        public virtual Task<OrderQueryDto> OrderQueryAsync(WeChatPayOrderQueryViewModel viewModel)
        {
            return  _wechatPayV2AppService.OrderQueryAsync(viewModel);
        }
        [HttpPost]
        [Route("payBank")]
        public virtual Task<PayBankDto> PayBankAsync(WeChatPayPayBankViewModel viewModel)
        {
            return  _wechatPayV2AppService.PayBankAsync(viewModel);
        }
        [HttpPost]
        [Route("profitSharingAddReceiver")]
        public virtual Task<ProfitSharingAddReceiverDto> ProfitSharingAddReceiverAsync(WeChatPayProfitSharingAddReceiverViewModel viewModel)
        {
            return  _wechatPayV2AppService.ProfitSharingAddReceiverAsync(viewModel);
        }
        [HttpPost]
        [Route("profitSharing")]
        public virtual Task<ProfitSharingDto> ProfitSharingAsync(WeChatPayProfitSharingViewModel viewModel)
        {
            return _wechatPayV2AppService.ProfitSharingAsync(viewModel);
        }
        [HttpPost]
        [Route("pubPay")]
        public virtual Task<PubPayDto> PubPayAsync(WeChatPayPubPayViewModel viewModel)
        {
            return  _wechatPayV2AppService.PubPayAsync(viewModel);
        }
        [HttpPost]
        [Route("qrCodePay")]
        public virtual Task<QrCodePayDto> QrCodePayAsync(WeChatPayQrCodePayViewModel viewModel)
        {
            return  _wechatPayV2AppService.QrCodePayAsync(viewModel);
        }
        [HttpPost]
        [Route("queryBank")]
        public virtual Task<QueryBankDto> QueryBankAsync(WeChatPayQueryBankViewModel viewModel)
        {
            return  _wechatPayV2AppService.QueryBankAsync(viewModel);
        }
        [HttpPost]
        [Route("refund")]
        public virtual Task<RefundDto> RefundAsync(WeChatPayRefundViewModel viewModel)
        {
            return  _wechatPayV2AppService.RefundAsync(viewModel);
        }
        [HttpPost]
        [Route("refundQuery")]
        public virtual Task<RefundQueryDto> RefundQueryAsync(WeChatPayRefundQueryViewModel viewModel)
        {
            return  _wechatPayV2AppService.RefundQueryAsync(viewModel);
        }
        [HttpPost]
        [Route("reverse")]
        public virtual Task<ReverseDto> ReverseAsync(WeChatPayReverseViewModel viewModel)
        {
            return  _wechatPayV2AppService.ReverseAsync(viewModel);
        }
        [HttpPost]
        [Route("transfers")]
        public virtual Task<TransfersDto> TransfersAsync(WeChatPayTransfersViewModel viewModel)
        {
            return  _wechatPayV2AppService.TransfersAsync(viewModel);
        }
    }
}
