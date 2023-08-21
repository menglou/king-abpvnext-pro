using King.AbpVnextPro.PayCenter.PayCenter.WeChat.V3;
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
    [RemoteService(Name = "WechatPayV3")]
    [ControllerName("WechatPayV3")]
    [Area("WechatPayV3")]
    [Route("/api/wechatPay/V3")]
    public class WechatPayV3Controller : PayCenterController, IWechatPayV3AppService
    {
        private IWechatPayV3AppService _wechatPayV3AppService;
        public WechatPayV3Controller(IWechatPayV3AppService wechatPayV3AppService)
        {
            _wechatPayV3AppService = wechatPayV3AppService;
        }
        [HttpPost]
        [Route("appPay")]
        public virtual Task<AppPayDto> AppPayAsync(WeChatPayAppPayV3ViewModel viewModel)
        {
            return _wechatPayV3AppService.AppPayAsync(viewModel);
        }
        [HttpPost]
        [Route("billDownload")]
        public virtual Task<BillDownloadDto> BillDownloadAsync(WeChatPayBillDownloadViewModel viewModel)
        {
            return _wechatPayV3AppService.BillDownloadAsync(viewModel);
        }
        [HttpPost]
        [Route("fundflowBill")]
        public virtual Task<FundflowBillDto> FundflowBillAsync(WeChatPayFundflowBillViewModel viewModel)
        {
            return _wechatPayV3AppService.FundflowBillAsync(viewModel);
        }
        [HttpPost]
        [Route("h5Pay")]
        public virtual Task<H5PayDto> H5PayAsync(WeChatPayH5PayV3ViewModel viewModel)
        {
            return _wechatPayV3AppService.H5PayAsync(viewModel);
        }
        [HttpPost]
        [Route("miniProgramPay")]
        public virtual Task<MiniProgramPayDto> MiniProgramPayAsync(WeChatPayPubPayV3ViewModel viewModel)
        {
            return _wechatPayV3AppService.MiniProgramPayAsync(viewModel);
        }
        [HttpPost]
        [Route("outTradeNoClose")]
        public virtual Task<OutTradeNoCloseDto> OutTradeNoCloseAsync(WeChatPayOutTradeNoCloseViewModel viewModel)
        {
            return _wechatPayV3AppService.OutTradeNoCloseAsync(viewModel);
        }
        [HttpPost]
        [Route("permissions")]
        public virtual Task<PermissionsDto> PermissionsAsync(PermissionsViewModel viewModel)
        {
            return _wechatPayV3AppService.PermissionsAsync(viewModel);
        }
        [HttpPost]
        [Route("permissionsQueryForAuthCode")]
        public virtual Task<PermissionsQueryForAuthCodeDto> PermissionsQueryForAuthCodeAsync(PermissionsQueryForAuthCodeViewModel viewModel)
        {
            return _wechatPayV3AppService.PermissionsQueryForAuthCodeAsync(viewModel);
        }
        [HttpPost]
        [Route("permissionsQueryForOpenId")]
        public virtual Task<PermissionsQueryForOpenIdDto> PermissionsQueryForOpenIdAsync(PermissionsQueryForOpenIdViewModel viewModel)
        {
            return _wechatPayV3AppService.PermissionsQueryForOpenIdAsync(viewModel);
        }
        [HttpPost]
        [Route("permissionsTerminateForAuthCode")]
        public virtual Task<PermissionsTerminateForAuthCodeDto> PermissionsTerminateForAuthCodeAsync(PermissionsTerminateForAuthCodeViewModel viewModel)
        {
            return _wechatPayV3AppService.PermissionsTerminateForAuthCodeAsync(viewModel);
        }
        [HttpPost]
        [Route("PermissionsTerminateForOpenId")]
        public virtual Task<PermissionsTerminateForOpenIdDto> PermissionsTerminateForOpenIdAsync(PermissionsTerminateForOpenIdViewModel viewModel)
        {
            return _wechatPayV3AppService.PermissionsTerminateForOpenIdAsync(viewModel);
        }
        [HttpPost]
        [Route("pubPay")]
        public virtual Task<PubPayDto> PubPayAsync(WeChatPayPubPayV3ViewModel viewModel)
        {
            return _wechatPayV3AppService.PubPayAsync(viewModel);
        }
        [HttpPost]
        [Route("qrCodePay")]
        public virtual Task<QrCodePayDto> QrCodePayAsync(WeChatPayQrCodePayV3ViewModel viewModel)
        {
            return _wechatPayV3AppService.QrCodePayAsync(viewModel);
        }
        [HttpPost]
        [Route("queryByOutTradeNo")]
        public virtual Task<QueryByOutTradeNoDto> QueryByOutTradeNoAsync(WeChatPayQueryByOutTradeNoViewModel viewModel)
        {
            return _wechatPayV3AppService.QueryByOutTradeNoAsync(viewModel);
        }
        [HttpPost]
        [Route("queryByTransactionId")]
        public virtual Task<QueryByTransactionIdDto> QueryByTransactionIdAsync(WeChatPayQueryByTransactionIdViewModel viewModel)
        {
            return _wechatPayV3AppService.QueryByTransactionIdAsync(viewModel);
        }
        [HttpPost]
        [Route("refund")]
        public virtual Task<RefundDto> RefundAsync(WeChatPayV3RefundViewModel viewModel)
        {
            return _wechatPayV3AppService.RefundAsync(viewModel);
        }
        [HttpPost]
        [Route("refundQuery")]
        public virtual Task<RefundQueryDto> RefundQueryAsync(WeChatPayV3RefundQueryViewModel viewModel)
        {
            return _wechatPayV3AppService.RefundQueryAsync(viewModel);
        }
        [HttpPost]
        [Route("serviceOrder")]
        public virtual Task<ServiceOrderDto> ServiceOrderAsync(WeChatPayScoreServiceOrderViewModel viewModel)
        {
            return _wechatPayV3AppService.ServiceOrderAsync(viewModel);
        }
        [HttpPost]
        [Route("serviceOrderCancel")]
        public virtual Task<ServiceOrderCancelDto> ServiceOrderCancelAsync(WeChatPayScoreServiceOrderCancelViewModel viewModel)
        {
            return _wechatPayV3AppService.ServiceOrderCancelAsync(viewModel);
        }
        [HttpPost]
        [Route("serviceOrderComplete")]
        public virtual Task<ServiceOrderCompleteDto> ServiceOrderCompleteAsync(WeChatPayScoreServiceOrderCompleteViewModel viewModel)
        {
            return _wechatPayV3AppService.ServiceOrderCompleteAsync(viewModel);
        }
        [HttpPost]
        [Route("serviceOrderDirectComplete")]
        public virtual Task<ServiceOrderDirectCompleteDto> ServiceOrderDirectCompleteAsync(WeChatPayScoreServiceOrderDirectCompleteViewModel viewModel)
        {
            return _wechatPayV3AppService.ServiceOrderDirectCompleteAsync(viewModel);
        }
        [HttpPost]
        [Route("serviceOrderModify")]
        public virtual Task<ServiceOrderModifyDto> ServiceOrderModifyAsync(WeChatPayScoreServiceOrderModifyViewModel viewModel)
        {
            return _wechatPayV3AppService.ServiceOrderModifyAsync(viewModel);
        }
        [HttpPost]
        [Route("serviceOrderPay")]
        public virtual Task<ServiceOrderPayDto> ServiceOrderPayAsync(WeChatPayScoreServiceOrderPayViewModel viewModel)
        {
            return _wechatPayV3AppService.ServiceOrderPayAsync(viewModel);
        }
        [HttpPost]
        [Route("serviceOrderQuery")]
        public virtual Task<ServiceOrderQueryDto> ServiceOrderQueryAsync(WeChatPayScoreServiceOrderQueryViewModel viewModel)
        {
            return _wechatPayV3AppService.ServiceOrderQueryAsync(viewModel);
        }
        [HttpPost]
        [Route("serviceOrderSync")]
        public virtual Task<ServiceOrderSyncDto> ServiceOrderSyncAsync(WeChatPayScoreServiceOrderSyncViewModel viewModel)
        {
            return _wechatPayV3AppService.ServiceOrderSyncAsync(viewModel);
        }
        [HttpPost]
        [Route("tradeBill")]
        public virtual Task<TradeBillDto> TradeBillAsync(WeChatPayTradeBillViewModel viewModel)
        {
            return _wechatPayV3AppService.TradeBillAsync(viewModel);
        }
    }
}
