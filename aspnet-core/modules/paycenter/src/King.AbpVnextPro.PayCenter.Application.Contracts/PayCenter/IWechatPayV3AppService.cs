using King.AbpVnextPro.PayCenter.PayCenter.WeChat.V3;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace King.AbpVnextPro.PayCenter.PayCenter
{
    public interface IWechatPayV3AppService: IApplicationService
    {
        Task<AppPayDto> AppPayAsync(WeChatPayAppPayV3ViewModel viewModel);
        Task<PubPayDto> PubPayAsync(WeChatPayPubPayV3ViewModel viewModel);
        Task<QrCodePayDto> QrCodePayAsync(WeChatPayQrCodePayV3ViewModel viewModel);
        Task<H5PayDto> H5PayAsync(WeChatPayH5PayV3ViewModel viewModel);
        Task<MiniProgramPayDto> MiniProgramPayAsync(WeChatPayPubPayV3ViewModel viewModel);
        Task<QueryByTransactionIdDto> QueryByTransactionIdAsync(WeChatPayQueryByTransactionIdViewModel viewModel);
        Task<QueryByOutTradeNoDto> QueryByOutTradeNoAsync(WeChatPayQueryByOutTradeNoViewModel viewModel);
        Task<OutTradeNoCloseDto> OutTradeNoCloseAsync(WeChatPayOutTradeNoCloseViewModel viewModel);
        Task<TradeBillDto> TradeBillAsync(WeChatPayTradeBillViewModel viewModel);
        Task<FundflowBillDto> FundflowBillAsync(WeChatPayFundflowBillViewModel viewModel);
        Task<BillDownloadDto> BillDownloadAsync(WeChatPayBillDownloadViewModel viewModel);
        Task<RefundDto> RefundAsync(WeChatPayV3RefundViewModel viewModel);
        Task<RefundQueryDto> RefundQueryAsync(WeChatPayV3RefundQueryViewModel viewModel);
        Task<ServiceOrderDto> ServiceOrderAsync(WeChatPayScoreServiceOrderViewModel viewModel);
        Task<ServiceOrderQueryDto> ServiceOrderQueryAsync(WeChatPayScoreServiceOrderQueryViewModel viewModel);
        Task<ServiceOrderCancelDto> ServiceOrderCancelAsync(WeChatPayScoreServiceOrderCancelViewModel viewModel);
        Task<ServiceOrderModifyDto> ServiceOrderModifyAsync(WeChatPayScoreServiceOrderModifyViewModel viewModel);
        Task<ServiceOrderCompleteDto> ServiceOrderCompleteAsync(WeChatPayScoreServiceOrderCompleteViewModel viewModel);
        Task<ServiceOrderPayDto> ServiceOrderPayAsync(WeChatPayScoreServiceOrderPayViewModel viewModel);
        Task<ServiceOrderSyncDto> ServiceOrderSyncAsync(WeChatPayScoreServiceOrderSyncViewModel viewModel);
        Task<ServiceOrderDirectCompleteDto> ServiceOrderDirectCompleteAsync(WeChatPayScoreServiceOrderDirectCompleteViewModel viewModel);
        Task<PermissionsDto> PermissionsAsync(PermissionsViewModel viewModel);
        Task<PermissionsQueryForAuthCodeDto> PermissionsQueryForAuthCodeAsync(PermissionsQueryForAuthCodeViewModel viewModel);
        Task<PermissionsTerminateForAuthCodeDto> PermissionsTerminateForAuthCodeAsync(PermissionsTerminateForAuthCodeViewModel viewModel);
        Task<PermissionsQueryForOpenIdDto> PermissionsQueryForOpenIdAsync(PermissionsQueryForOpenIdViewModel viewModel);
        Task<PermissionsTerminateForOpenIdDto> PermissionsTerminateForOpenIdAsync(PermissionsTerminateForOpenIdViewModel viewModel);

    }
}
