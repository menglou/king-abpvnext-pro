using King.AbpVnextPro.PayCenter.PayCenter.WeChat.V2;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace King.AbpVnextPro.PayCenter.PayCenter
{
    public  interface IWechatPayV2AppService:IApplicationService
    {
        Task<MicroPayDto> MicroPayAsync(WeChatPayMicroPayViewModel viewModel);
        Task<PubPayDto> PubPayAsync(WeChatPayPubPayViewModel viewModel);
        Task<QrCodePayDto> QrCodePayAsync(WeChatPayQrCodePayViewModel viewModel);
        Task<AppPayDto> AppPayAsync(WeChatPayAppPayViewModel viewModel);
        Task<H5PayDto> H5PayAsync(WeChatPayH5PayViewModel viewModel);
        Task<MiniProgramPayDto> MiniProgramPayAsync(WeChatPayMiniProgramPayViewModel viewModel);
        Task<OrderQueryDto> OrderQueryAsync(WeChatPayOrderQueryViewModel viewModel);
        Task<ReverseDto> ReverseAsync(WeChatPayReverseViewModel viewModel);
        Task<CloseOrderDto> CloseOrderAsync(WeChatPayCloseOrderViewModel viewModel);
        Task<RefundDto> RefundAsync(WeChatPayRefundViewModel viewModel);
        Task<RefundQueryDto> RefundQueryAsync(WeChatPayRefundQueryViewModel viewModel);
        Task<DownloadBillDto> DownloadBillAsync(WeChatPayDownloadBillViewModel viewModel);
        Task<DownloadFundFlowDto> DownloadFundFlowAsync(WeChatPayDownloadFundFlowViewModel viewModel);
        Task<TransfersDto> TransfersAsync(WeChatPayTransfersViewModel viewModel);
        Task<GetTransferInfoDto> GetTransferInfoAsync(WeChatPayGetTransferInfoViewModel viewModel);
        Task<PayBankDto> PayBankAsync(WeChatPayPayBankViewModel viewModel);
        Task<QueryBankDto> QueryBankAsync(WeChatPayQueryBankViewModel viewModel);
        Task<GetPublicKeyDto> GetPublicKeyAsync();
        Task<ProfitSharingAddReceiverDto> ProfitSharingAddReceiverAsync(WeChatPayProfitSharingAddReceiverViewModel viewModel);
        Task<ProfitSharingDto> ProfitSharingAsync(WeChatPayProfitSharingViewModel viewModel);
    }
}
