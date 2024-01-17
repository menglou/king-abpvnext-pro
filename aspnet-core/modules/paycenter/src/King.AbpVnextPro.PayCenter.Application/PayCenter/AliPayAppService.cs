using King.AbpVnextPro.PayCenter.PayCenter.AliPay;
using King.AbpVnextPro.Paylink.Alipy;
using King.AbpVnextPro.Paylink.Alipy.Domain;
using King.AbpVnextPro.Paylink.Alipy.Request;
using King.AbpVnextPro.Paylink.WeChat;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King.AbpVnextPro.PayCenter.PayCenter
{
    public  class AliPayAppService:PayCenterAppService,IAliPayAppService
    {
        private readonly IAlipayClient _client;
        private readonly ILogger<AliPayAppService> _logger;
        private readonly IGetAlipaySettingService _getAlipaySettingService;
        private readonly AlipayOptions  alipayOptions;
        public AliPayAppService(ILogger<AliPayAppService> logger, IGetAlipaySettingService getAlipaySettingService, IAlipayClient client)
        {
            _client = client;
            _logger = logger;
            _getAlipaySettingService = getAlipaySettingService;
            alipayOptions = _getAlipaySettingService.GetAlipaySettingAsync().Result;
        }


        /// <summary>
        /// 当面付-扫码支付
        /// </summary>
        public virtual async Task<PreCreateDto> PreCreateAsync(AlipayTradePreCreateViewModel viewModel)
        {
            PreCreateDto preCreateDto = new PreCreateDto();
            var model = new AlipayTradePrecreateModel
            {
                OutTradeNo = viewModel.OutTradeNo,
                Subject = viewModel.Subject,
                TotalAmount = viewModel.TotalAmount,
                Body = viewModel.Body
            };
            var req = new AlipayTradePrecreateRequest();
            req.SetBizModel(model);
            req.SetNotifyUrl(viewModel.NotifyUrl);

            var response = await _client.CertificateExecuteAsync(req, alipayOptions);
            preCreateDto.AlipayTradePrecreateResponse= response;
            return preCreateDto;
        }

        

        /// <summary>
        /// 当面付-二维码/条码/声波支付
        /// </summary>
        public virtual async Task<PayDto> PayAsync(AlipayTradePayViewModel viewModel)
        {
            PayDto payDto = new PayDto();
            var model = new AlipayTradePayModel
            {
                OutTradeNo = viewModel.OutTradeNo,
                Subject = viewModel.Subject,
                Scene = viewModel.Scene,
                AuthCode = viewModel.AuthCode,
                TotalAmount = viewModel.TotalAmount,
                Body = viewModel.Body
            };
            var req = new AlipayTradePayRequest();
            req.SetBizModel(model);

            var response = await _client.CertificateExecuteAsync(req, alipayOptions);
            payDto.AlipayTradePayResponse= response;
            return payDto;
        }

        /// <summary>
        /// APP支付
        /// </summary>
        public virtual async Task<AppPayDto> AppPayAsync(AlipayTradeAppPayViewModel viewModel)
        {
            AppPayDto payDto=new AppPayDto();
            var model = new AlipayTradeAppPayModel
            {
                OutTradeNo = viewModel.OutTradeNo,
                Subject = viewModel.Subject,
                ProductCode = viewModel.ProductCode,
                TotalAmount = viewModel.TotalAmount,
                Body = viewModel.Body
            };
            var req = new AlipayTradeAppPayRequest();
            req.SetBizModel(model);
            req.SetNotifyUrl(viewModel.NotifyUrl);

            var response = await _client.SdkExecuteAsync(req, alipayOptions);
            // 将response.Body给 ios、android端，由其去完成调起支付宝APP。
            // 客户端 Android 集成流程: https://opendocs.alipay.com/open/204/105296/
            // 客户端 iOS 集成流程: https://opendocs.alipay.com/open/204/105295/
            payDto.AlipayTradeAppPayResponse= response;
            return payDto;
        }

       

        /// <summary>
        /// 电脑网站支付
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<PagePayDto> PagePayAsync(AlipayTradePagePayViewModel viewModel)
        {
            PagePayDto payDto = new PagePayDto();
            var model = new AlipayTradePagePayModel
            {
                Body = viewModel.Body,
                Subject = viewModel.Subject,
                TotalAmount = viewModel.TotalAmount,
                OutTradeNo = viewModel.OutTradeNo,
                ProductCode = viewModel.ProductCode
            };
            var req = new AlipayTradePagePayRequest();
            req.SetBizModel(model);
            req.SetNotifyUrl(viewModel.NotifyUrl);
            req.SetReturnUrl(viewModel.ReturnUrl);

            var response = await _client.PageExecuteAsync(req, alipayOptions);
            payDto.AlipayTradePagePayResponse = response;
            return payDto;
        }
        /// <summary>
        /// 手机网站支付
        /// </summary>
        public virtual async Task<WapPayDto> WapPayAsync(AlipayTradeWapPayViewModel viewMode)
        {
            WapPayDto wapPayDto = new WapPayDto();
            var model = new AlipayTradeWapPayModel
            {
                Body = viewMode.Body,
                Subject = viewMode.Subject,
                TotalAmount = viewMode.TotalAmount,
                OutTradeNo = viewMode.OutTradeNo,
                ProductCode = viewMode.ProductCode
            };
            var req = new AlipayTradeWapPayRequest();
            req.SetBizModel(model);
            req.SetNotifyUrl(viewMode.NotifyUrl);
            req.SetReturnUrl(viewMode.ReturnUrl);

            var response = await _client.PageExecuteAsync(req, alipayOptions);
            wapPayDto.AlipayTradeWapPayResponse = response;
            return wapPayDto;
        }

       
        /// <summary>
        /// 交易查询
        /// </summary>
        public virtual async Task<QueryDto> QueryAsyc(AlipayTradeQueryViewModel viewMode)
        {
            QueryDto queryDto = new QueryDto();
            var model = new AlipayTradeQueryModel
            {
                OutTradeNo = viewMode.OutTradeNo,
                TradeNo = viewMode.TradeNo
            };

            var req = new AlipayTradeQueryRequest();
            req.SetBizModel(model);

            var response = await _client.CertificateExecuteAsync(req, alipayOptions);
            queryDto.AlipayTradeQueryResponse= response;
            return queryDto;
        }

       
        /// <summary>
        /// 交易退款
        /// </summary>
        public virtual async Task<RefundDto> RefundAsync(AlipayTradeRefundViewModel viewMode)
        {
            RefundDto refundDto = new RefundDto();
            var model = new AlipayTradeRefundModel
            {
                OutTradeNo = viewMode.OutTradeNo,
                TradeNo = viewMode.TradeNo,
                RefundAmount = viewMode.RefundAmount,
                OutRequestNo = viewMode.OutRequestNo,
                RefundReason = viewMode.RefundReason
            };

            var req = new AlipayTradeRefundRequest();
            req.SetBizModel(model);

            var response = await _client.CertificateExecuteAsync(req, alipayOptions);
            refundDto.AlipayTradeRefundResponse= response;
            return refundDto;
        }

       

        /// <summary>
        /// 退款查询
        /// </summary>
        public virtual async Task<RefundQueryDto> RefundQueryAsync(AlipayTradeRefundQueryViewModel viewMode)
        {
            RefundQueryDto refundQueryDto = new RefundQueryDto();
            var model = new AlipayTradeFastpayRefundQueryModel
            {
                OutTradeNo = viewMode.OutTradeNo,
                TradeNo = viewMode.TradeNo,
                OutRequestNo = viewMode.OutRequestNo
            };

            var req = new AlipayTradeFastpayRefundQueryRequest();
            req.SetBizModel(model);

            var response = await _client.CertificateExecuteAsync(req, alipayOptions);
            refundQueryDto.AlipayTradeFastpayRefundQueryResponse= response;
            return refundQueryDto;
        }

       
        /// <summary>
        /// 交易关闭
        /// </summary>
        public virtual async Task<CloseDto> CloseAsync(AlipayTradeCloseViewModel viewMode)
        {
            CloseDto closeDto = new CloseDto();
            var model = new AlipayTradeCloseModel
            {
                OutTradeNo = viewMode.OutTradeNo,
                TradeNo = viewMode.TradeNo,
            };

            var req = new AlipayTradeCloseRequest();
            req.SetBizModel(model);
            req.SetNotifyUrl(viewMode.NotifyUrl);

            var response = await _client.CertificateExecuteAsync(req, alipayOptions);
            closeDto.AlipayTradeCloseResponse= response;
            return closeDto;
        }

       

        /// <summary>
        /// 统一转账
        /// </summary>
        public virtual async Task<TransferDto> TransferAsync(AlipayTransferViewModel viewMode)
        {
            TransferDto transferDto = new TransferDto();
            var model = new AlipayFundTransUniTransferModel
            {
                OutBizNo = viewMode.OutBizNo,
                TransAmount = viewMode.TransAmount,
                ProductCode = viewMode.ProductCode,
                BizScene = viewMode.BizScene,
                PayeeInfo = new Participant { Identity = viewMode.PayeeIdentity, IdentityType = viewMode.PayeeIdentityType, Name = viewMode.PayeeName },
                Remark = viewMode.Remark
            };
            var req = new AlipayFundTransUniTransferRequest();
            req.SetBizModel(model);
            var response = await _client.CertificateExecuteAsync(req, alipayOptions);
            transferDto.AlipayFundTransUniTransferResponse= response;
            return transferDto;
        }

       

        /// <summary>
        /// 查询统一转账订单
        /// </summary>
        public virtual async Task<TransQueryDto> TransQueryAsync(AlipayTransQueryViewModel viewMode)
        {
            TransQueryDto transQueryDto = new TransQueryDto();
            var model = new AlipayFundTransCommonQueryModel
            {
                OutBizNo = viewMode.OutBizNo,
                OrderId = viewMode.OrderId
            };

            var req = new AlipayFundTransCommonQueryRequest();
            req.SetBizModel(model);
            var response = await _client.CertificateExecuteAsync(req, alipayOptions);
            transQueryDto.AlipayFundTransCommonQueryResponse= response;
            return transQueryDto;
        }

       

        /// <summary>
        /// 余额查询
        /// </summary>
        public virtual async Task<AccountQueryDto> AccountQueryAsync(AlipayAccountQueryViewModel viewModel)
        {
            AccountQueryDto accountQueryDto = new AccountQueryDto();
            var model = new AlipayFundAccountQueryModel
            {
                AlipayUserId = viewModel.AlipayUserId,
                AccountType = viewModel.AccountType
            };

            var req = new AlipayFundAccountQueryRequest();
            req.SetBizModel(model);
            var response = await _client.CertificateExecuteAsync(req, alipayOptions);
            accountQueryDto.AlipayFundAccountQueryResponse= response;
            return accountQueryDto;
        }
    }
}
