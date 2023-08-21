
using King.AbpVnextPro.PayCenter.PayCenter.WeChat.V2;
using King.AbpVnextPro.Paylink.WeChat;
using King.AbpVnextPro.Paylink.WeChat.V2;
using King.AbpVnextPro.Paylink.WeChat.V2.Request;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Settings;

namespace King.AbpVnextPro.PayCenter.PayCenter
{
    public class WechatPayV2AppService : PayCenterAppService, IWechatPayV2AppService
    {
        private readonly IWeChatPayClient _client;
        private readonly ILogger<WechatPayV2AppService> _logger;
        private readonly IGetWeChatSettingService _getWeChatSettingService;
        private readonly WeChatPayOptions weChatPayOptions;
        public WechatPayV2AppService(ILogger<WechatPayV2AppService> logger, IGetWeChatSettingService getWeChatSettingService, IWeChatPayClient client)
        {
            _client = client;
            _logger = logger;
            _getWeChatSettingService = getWeChatSettingService;
            weChatPayOptions = _getWeChatSettingService.GetWeChatSettingAsync().Result;
        }

        /// <summary>
        /// 刷卡支付
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<MicroPayDto> MicroPayAsync(WeChatPayMicroPayViewModel viewModel)
        {
            MicroPayDto microPayDto = new MicroPayDto();
            var request = new WeChatPayMicroPayRequest
            {
                Body = viewModel.Body,
                OutTradeNo = viewModel.OutTradeNo,
                TotalFee = viewModel.TotalFee,
                SpBillCreateIp = viewModel.SpBillCreateIp,
                AuthCode = viewModel.AuthCode
            };
            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            microPayDto.WeChatPayMicroPayResponse = response;
            return microPayDto;
        }

        /// <summary>
        /// 公众号支付
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<PubPayDto> PubPayAsync(WeChatPayPubPayViewModel viewModel)
        {
            PubPayDto pubPayDto=new PubPayDto();
            var request = new WeChatPayUnifiedOrderRequest
            {
                Body = viewModel.Body,
                OutTradeNo = viewModel.OutTradeNo,
                TotalFee = viewModel.TotalFee,
                SpBillCreateIp = viewModel.SpBillCreateIp,
                NotifyUrl = viewModel.NotifyUrl,
                TradeType = viewModel.TradeType,
                OpenId = viewModel.OpenId
            };

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            pubPayDto.WeChatPayUnifiedOrderResponse = response;
            if (response.ReturnCode == WeChatPayCode.Success && response.ResultCode == WeChatPayCode.Success)
            {
                var req = new WeChatPayJsApiSdkRequest
                {
                    Package = "prepay_id=" + response.PrepayId
                };
                var parameter = await _client.ExecuteAsync(req, weChatPayOptions);
                // 将参数(parameter)给 公众号前端 让他在微信内H5调起支付(https://pay.weixin.qq.com/wiki/doc/api/jsapi.php?chapter=7_7&index=6)
                pubPayDto.WeChatPayDictionary= parameter;
            }
            return pubPayDto;
        }


        /// <summary>
        /// 扫码支付
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<QrCodePayDto> QrCodePayAsync(WeChatPayQrCodePayViewModel viewModel)
        {
            QrCodePayDto qrCodePayDto = new QrCodePayDto();
            var request = new WeChatPayUnifiedOrderRequest
            {
                Body = viewModel.Body,
                OutTradeNo = viewModel.OutTradeNo,
                TotalFee = viewModel.TotalFee,
                SpBillCreateIp = viewModel.SpBillCreateIp,
                NotifyUrl = viewModel.NotifyUrl,
                TradeType = viewModel.TradeType,
                ProfitSharing = viewModel.ProfitSharing
            };

            var response = await _client.ExecuteAsync(request, weChatPayOptions);

            qrCodePayDto.WeChatPayUnifiedOrderResponse = response;
            // response.CodeUrl 给前端生成二维码
            return qrCodePayDto;
        }

        /// <summary>
        /// APP支付
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<AppPayDto> AppPayAsync(WeChatPayAppPayViewModel viewModel)
        {
            AppPayDto appPayDto=new AppPayDto();
            var request = new WeChatPayUnifiedOrderRequest
            {
                Body = viewModel.Body,
                OutTradeNo = viewModel.OutTradeNo,
                TotalFee = viewModel.TotalFee,
                SpBillCreateIp = viewModel.SpBillCreateIp,
                NotifyUrl = viewModel.NotifyUrl,
                TradeType = viewModel.TradeType
            };
            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            appPayDto.WeChatPayUnifiedOrderResponse= response;
            if (response.ReturnCode == WeChatPayCode.Success && response.ResultCode == WeChatPayCode.Success)
            {
                var req = new WeChatPayAppSdkRequest
                {
                    PrepayId = response.PrepayId
                };

                var parameter = await _client.ExecuteAsync(req, weChatPayOptions);

                // 将参数(parameter)给 ios/android端 让他调起微信APP(https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=8_5)
                appPayDto.WeChatPayDictionary= parameter;
            }
            return appPayDto;
        }

        /// <summary>
        /// H5支付
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<H5PayDto> H5PayAsync(WeChatPayH5PayViewModel viewModel)
        {
            H5PayDto h5PayDto = new H5PayDto();
            var request = new WeChatPayUnifiedOrderRequest
            {
                Body = viewModel.Body,
                OutTradeNo = viewModel.OutTradeNo,
                TotalFee = viewModel.TotalFee,
                SpBillCreateIp = viewModel.SpBillCreateIp,
                NotifyUrl = viewModel.NotifyUrl,
                TradeType = viewModel.TradeType
            };

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            h5PayDto.WeChatPayUnifiedOrderResponse = response;
            // mweb_url为拉起微信支付收银台的中间页面，可通过访问该url来拉起微信客户端，完成支付,mweb_url的有效期为5分钟。
            return h5PayDto;
        }

        /// <summary>
        /// 小程序支付
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<MiniProgramPayDto> MiniProgramPayAsync(WeChatPayMiniProgramPayViewModel viewModel)
        {
            MiniProgramPayDto miniProgramPayDto = new MiniProgramPayDto();
            var request = new WeChatPayUnifiedOrderRequest
            {
                Body = viewModel.Body,
                OutTradeNo = viewModel.OutTradeNo,
                TotalFee = viewModel.TotalFee,
                SpBillCreateIp = viewModel.SpBillCreateIp,
                NotifyUrl = viewModel.NotifyUrl,
                TradeType = viewModel.TradeType,
                OpenId = viewModel.OpenId
            };

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            miniProgramPayDto.WeChatPayUnifiedOrderResponse = response;
            if (response.ReturnCode == WeChatPayCode.Success && response.ResultCode == WeChatPayCode.Success)
            {
                var req = new WeChatPayMiniProgramSdkRequest
                {
                    Package = "prepay_id=" + response.PrepayId
                };

                var parameter = await _client.ExecuteAsync(req, weChatPayOptions);

                // 将参数(parameter)给 小程序前端 让他调起支付API(https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=7_7&index=5)
                miniProgramPayDto.WeChatPayDictionary = parameter;
            }
            return miniProgramPayDto;
        }

        /// <summary>
        /// 查询订单
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<OrderQueryDto> OrderQueryAsync(WeChatPayOrderQueryViewModel viewModel)
        {
            OrderQueryDto orderQueryDto = new OrderQueryDto();
            var request = new WeChatPayOrderQueryRequest
            {
                TransactionId = viewModel.TransactionId,
                OutTradeNo = viewModel.OutTradeNo
            };
            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            orderQueryDto.WeChatPayOrderQueryResponse = response;
            return orderQueryDto;
        }

        /// <summary>
        /// 撤销订单
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<ReverseDto> ReverseAsync(WeChatPayReverseViewModel viewModel)
        {
            ReverseDto reverseDto = new ReverseDto();
            var request = new WeChatPayReverseRequest
            {
                TransactionId = viewModel.TransactionId,
                OutTradeNo = viewModel.OutTradeNo
            };
            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            reverseDto.WeChatPayReverseResponse = response;
            return reverseDto;
        }

        /// <summary>
        /// 关闭订单
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<CloseOrderDto> CloseOrderAsync(WeChatPayCloseOrderViewModel viewModel)
        {
            CloseOrderDto closeOrderDto = new CloseOrderDto();
            var request = new WeChatPayCloseOrderRequest
            {
                OutTradeNo = viewModel.OutTradeNo
            };
            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            closeOrderDto.WeChatPayCloseOrderResponse = response;
            return closeOrderDto;
        }

        /// <summary>
        /// 申请退款
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<RefundDto> RefundAsync(WeChatPayRefundViewModel viewModel)
        {
            RefundDto refundDto= new RefundDto();   
            var request = new WeChatPayRefundRequest
            {
                OutRefundNo = viewModel.OutRefundNo,
                TransactionId = viewModel.TransactionId,
                OutTradeNo = viewModel.OutTradeNo,
                TotalFee = viewModel.TotalFee,
                RefundFee = viewModel.RefundFee,
                RefundDesc = viewModel.RefundDesc,
                NotifyUrl = viewModel.NotifyUrl
            };
            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            refundDto.WeChatPayRefundResponse = response;
            return refundDto;
        }

        /// <summary>
        /// 查询退款
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<RefundQueryDto> RefundQueryAsync(WeChatPayRefundQueryViewModel viewModel)
        {
            RefundQueryDto refundQueryDto = new RefundQueryDto();
            var request = new WeChatPayRefundQueryRequest
            {
                RefundId = viewModel.RefundId,
                OutRefundNo = viewModel.OutRefundNo,
                TransactionId = viewModel.TransactionId,
                OutTradeNo = viewModel.OutTradeNo
            };
            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            refundQueryDto.WeChatPayRefundQueryResponse = response;
            return refundQueryDto;
        }

        /// <summary>
        /// 下载对账单
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<DownloadBillDto> DownloadBillAsync(WeChatPayDownloadBillViewModel viewModel)
        {
            DownloadBillDto downloadBillDto=new DownloadBillDto();  
            var request = new WeChatPayDownloadBillRequest
            {
                BillDate = viewModel.BillDate,
                BillType = viewModel.BillType,
                TarType = viewModel.TarType
            };
            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            downloadBillDto.WeChatPayDownloadBillResponse = response;
            return downloadBillDto;
        }

        /// <summary>
        /// 下载资金账单
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<DownloadFundFlowDto> DownloadFundFlowAsync(WeChatPayDownloadFundFlowViewModel viewModel)
        {
            DownloadFundFlowDto downloadFundFlowDto=new DownloadFundFlowDto();  
            var request = new WeChatPayDownloadFundFlowRequest
            {
                BillDate = viewModel.BillDate,
                AccountType = viewModel.AccountType,
                TarType = viewModel.TarType
            };
            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            downloadFundFlowDto.WeChatPayDownloadFundFlowResponse = response;
            return downloadFundFlowDto;
        }

        /// <summary>
        /// 企业付款到零钱
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<TransfersDto> TransfersAsync(WeChatPayTransfersViewModel viewModel)
        {
            TransfersDto transfersDto=new TransfersDto();   
            var request = new WeChatPayPromotionTransfersRequest
            {
                PartnerTradeNo = viewModel.PartnerTradeNo,
                OpenId = viewModel.OpenId,
                CheckName = viewModel.CheckName,
                ReUserName = viewModel.ReUserName,
                Amount = viewModel.Amount,
                Desc = viewModel.Desc,
                SpBillCreateIp = viewModel.SpBillCreateIp
            };
            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            transfersDto.WeChatPayPromotionTransfersResponse = response;
            return transfersDto;
        }

        /// <summary>
        /// 查询企业付款
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<GetTransferInfoDto> GetTransferInfoAsync(WeChatPayGetTransferInfoViewModel viewModel)
        {
            GetTransferInfoDto getTransferInfoDto = new GetTransferInfoDto();
            var request = new WeChatPayGetTransferInfoRequest
            {
                PartnerTradeNo = viewModel.PartnerTradeNo
            };
            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            getTransferInfoDto.WeChatPayGetTransferInfoResponse = response;
            return getTransferInfoDto;
        }

        /// <summary>
        /// 企业付款到银行卡
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<PayBankDto> PayBankAsync(WeChatPayPayBankViewModel viewModel)
        {
            PayBankDto payBankDto=new PayBankDto();
            var request = new WeChatPayPayBankRequest
            {
                PartnerTradeNo = viewModel.PartnerTradeNo,
                BankNo = viewModel.BankNo,
                TrueName = viewModel.TrueName,
                BankCode = viewModel.BankCode,
                Amount = viewModel.Amount,
                Desc = viewModel.Desc
            };
            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            payBankDto.WeChatPayPayBankResponse = response;
            return payBankDto;
        }

        /// <summary>
        /// 查询企业付款银行卡
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<QueryBankDto> QueryBankAsync(WeChatPayQueryBankViewModel viewModel)
        {
            QueryBankDto queryBankDto=new QueryBankDto();   
            var request = new WeChatPayQueryBankRequest
            {
                PartnerTradeNo = viewModel.PartnerTradeNo
            };
            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            queryBankDto.WeChatPayQueryBankResponse = response;
            return queryBankDto;
        }

        /// <summary>
        /// 获取RSA加密公钥
        /// </summary>
        public virtual async Task<GetPublicKeyDto> GetPublicKeyAsync()
        {
            GetPublicKeyDto getPublicKeyDto = new GetPublicKeyDto();
            var request = new WeChatPayRiskGetPublicKeyRequest();
            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            getPublicKeyDto.WeChatPayRiskGetPublicKeyResponse = response;
            return getPublicKeyDto;
        }


        /// <summary>
        /// 添加分账接收方
        /// </summary>
        public virtual async Task<ProfitSharingAddReceiverDto> ProfitSharingAddReceiverAsync(WeChatPayProfitSharingAddReceiverViewModel viewModel)
        {
            ProfitSharingAddReceiverDto profitSharingAddReceiverDto=new ProfitSharingAddReceiverDto();
            var request = new WeChatPayProfitSharingAddReceiverRequest
            {
                Receiver = viewModel.Receiver
            };
            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            profitSharingAddReceiverDto.WeChatPayProfitSharingAddReceiverResponse= response;
            return profitSharingAddReceiverDto;
        }

        /// <summary>
        /// 单次分账
        /// </summary>
        public virtual async Task<ProfitSharingDto> ProfitSharingAsync(WeChatPayProfitSharingViewModel viewModel)
        {
            ProfitSharingDto profitSharingDto = new ProfitSharingDto();
            var request = new WeChatPayProfitSharingRequest
            {
                TransactionId = viewModel.TransactionId,
                OutOrderNo = viewModel.OutOrderNo,
                Receivers = viewModel.Receivers
            };
            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            profitSharingDto.WeChatPayProfitSharingResponse= response;
            return profitSharingDto;
        }

    }
}
