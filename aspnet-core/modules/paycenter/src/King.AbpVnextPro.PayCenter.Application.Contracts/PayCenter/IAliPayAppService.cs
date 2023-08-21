using King.AbpVnextPro.PayCenter.PayCenter.AliPay;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace King.AbpVnextPro.PayCenter.PayCenter
{
    public interface IAliPayAppService : IApplicationService
    {
        Task<PreCreateDto> PreCreateAsync(AlipayTradePreCreateViewModel viewModel);
        Task<PayDto> PayAsync(AlipayTradePayViewModel viewModel);
        Task<AppPayDto> AppPayAsync(AlipayTradeAppPayViewModel viewModel);
        Task<PagePayDto> PagePayAsync(AlipayTradePagePayViewModel viewModel);
        Task<WapPayDto> WapPayAsync(AlipayTradeWapPayViewModel viewMode);
        Task<QueryDto> QueryAsyc(AlipayTradeQueryViewModel viewMode);
        Task<RefundDto> RefundAsync(AlipayTradeRefundViewModel viewMode);
        Task<RefundQueryDto> RefundQueryAsync(AlipayTradeRefundQueryViewModel viewMode);
        Task<CloseDto> CloseAsync(AlipayTradeCloseViewModel viewMode);
        Task<TransferDto> TransferAsync(AlipayTransferViewModel viewMode);
        Task<TransQueryDto> TransQueryAsync(AlipayTransQueryViewModel viewMode);
        Task<AccountQueryDto> AccountQueryAsync(AlipayAccountQueryViewModel viewModel);
    }
}
