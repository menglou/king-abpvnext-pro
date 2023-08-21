using King.AbpVnextPro.PayCenter.PayCenter.WeChat.V3;
using King.AbpVnextPro.Paylink.WeChat;
using King.AbpVnextPro.Paylink.WeChat.V3;
using King.AbpVnextPro.Paylink.WeChat.V3.Domain;
using King.AbpVnextPro.Paylink.WeChat.V3.Request;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King.AbpVnextPro.PayCenter.PayCenter
{
    public class WechatPayV3AppService: PayCenterAppService, IWechatPayV3AppService
    {
        private readonly IWeChatPayClient _client;
        private readonly ILogger<WechatPayV3AppService> _logger;
        private readonly IGetWeChatSettingService _getWeChatSettingService;
        private readonly WeChatPayOptions weChatPayOptions;
        public WechatPayV3AppService(ILogger<WechatPayV3AppService> logger, IGetWeChatSettingService getWeChatSettingService, IWeChatPayClient client)
        {
            _client = client;
            _logger = logger;
            _getWeChatSettingService = getWeChatSettingService;
            weChatPayOptions = _getWeChatSettingService.GetWeChatSettingAsync().Result;
        }

       
        /// <summary>
        /// APP支付-App下单API
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<AppPayDto> AppPayAsync(WeChatPayAppPayV3ViewModel viewModel)
        {
            AppPayDto appPayDto = new AppPayDto();
            var model = new WeChatPayTransactionsAppBodyModel
            {
                AppId = weChatPayOptions.AppId,
                MchId = weChatPayOptions.MchId,
                Amount = new Amount { Total = viewModel.Total, Currency = "CNY" },
                Description = viewModel.Description,
                NotifyUrl = viewModel.NotifyUrl,
                OutTradeNo = viewModel.OutTradeNo,
            };

            var request = new WeChatPayTransactionsAppRequest();
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            appPayDto.WeChatPayTransactionsAppResponse= response;
            if (!response.IsError)
            {
                var req = new WeChatPayAppSdkRequest
                {
                    PrepayId = response.PrepayId
                };

                var parameter = await _client.ExecuteAsync(req, weChatPayOptions);

                // 将参数(parameter)给 ios/android端 
                // https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_4.shtml
                appPayDto.WeChatPayDictionary = parameter;
            }
            return appPayDto;
        }

       
        /// <summary>
        /// 公众号支付-JSAPI下单
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<PubPayDto> PubPayAsync(WeChatPayPubPayV3ViewModel viewModel)
        {
            PubPayDto pubPayDto = new PubPayDto();
            var model = new WeChatPayTransactionsJsApiBodyModel
            {
                AppId = weChatPayOptions.AppId,
                MchId = weChatPayOptions.MchId,
                Amount = new Amount { Total = viewModel.Total, Currency = "CNY" },
                Description = viewModel.Description,
                NotifyUrl = viewModel.NotifyUrl,
                OutTradeNo = viewModel.OutTradeNo,
                Payer = new PayerInfo { OpenId = viewModel.OpenId }
            };

            var request = new WeChatPayTransactionsJsApiRequest();
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            pubPayDto.WeChatPayTransactionsJsApiResponse = response;
            if (!response.IsError)
            {
                var req = new WeChatPayJsApiSdkRequest
                {
                    Package = "prepay_id=" + response.PrepayId
                };

                var parameter = await _client.ExecuteAsync(req, weChatPayOptions);

                // 将参数(parameter)给 公众号前端
                // https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_4.shtml
                pubPayDto.WeChatPayDictionary = parameter;
            }

            return pubPayDto;
        }

        

        /// <summary>
        /// 扫码支付-Native下单API
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<QrCodePayDto> QrCodePayAsync(WeChatPayQrCodePayV3ViewModel viewModel)
        {
            QrCodePayDto qrCodePayDto = new QrCodePayDto();
            var model = new WeChatPayTransactionsNativeBodyModel
            {
                AppId = weChatPayOptions.AppId,
                MchId = weChatPayOptions.MchId,
                Amount = new Amount { Total = viewModel.Total, Currency = "CNY" },
                Description = viewModel.Description,
                NotifyUrl = viewModel.NotifyUrl,
                OutTradeNo = viewModel.OutTradeNo,
            };

            var request = new WeChatPayTransactionsNativeRequest();
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            qrCodePayDto.WeChatPayTransactionsNativeResponse = response;
            if (!response.IsError)
            {
                // response.CodeUrl 给前端生成二维码
                
            }
            
            return qrCodePayDto;
        }

      
        /// <summary>
        /// H5支付-H5下单API
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<H5PayDto> H5PayAsync(WeChatPayH5PayV3ViewModel viewModel)
        {
            H5PayDto h5PayDto = new H5PayDto();
            var model = new WeChatPayTransactionsH5BodyModel
            {
                AppId = weChatPayOptions.AppId,
                MchId = weChatPayOptions.MchId,
                Amount = new Amount { Total = viewModel.Total, Currency = "CNY" },
                Description = viewModel.Description,
                NotifyUrl = viewModel.NotifyUrl,
                OutTradeNo = viewModel.OutTradeNo,
                SceneInfo = new SceneInfo { PayerClientIp = "127.0.0.1", H5Info = new H5Info { Type = "Wap" } }
            };

            var request = new WeChatPayTransactionsH5Request();
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);

            // h5_url为拉起微信支付收银台的中间页面，可通过访问该url来拉起微信客户端，完成支付,h5_url的有效期为5分钟。
            // https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_4.shtml
            h5PayDto.WeChatPayTransactionsH5Response = response;
            return h5PayDto;
        }

       

        /// <summary>
        /// 小程序支付-JSAPI下单
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<MiniProgramPayDto> MiniProgramPayAsync(WeChatPayPubPayV3ViewModel viewModel)
        {
            MiniProgramPayDto miniProgramPayDto = new MiniProgramPayDto();
            var model = new WeChatPayTransactionsJsApiBodyModel
            {
                AppId = weChatPayOptions.AppId,
                MchId = weChatPayOptions.MchId,
                Amount = new Amount { Total = viewModel.Total, Currency = "CNY" },
                Description = viewModel.Description,
                NotifyUrl = viewModel.NotifyUrl,
                OutTradeNo = viewModel.OutTradeNo,
                Payer = new PayerInfo { OpenId = viewModel.OpenId }
            };

            var request = new WeChatPayTransactionsJsApiRequest();
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            miniProgramPayDto.WeChatPayTransactionsJsApiResponse = response;

            if (!response.IsError)
            {
                var req = new WeChatPayMiniProgramSdkRequest
                {
                    Package = "prepay_id=" + response.PrepayId
                };

                var parameter = await _client.ExecuteAsync(req, weChatPayOptions);
                miniProgramPayDto.WeChatPayDictionary = parameter;
                // 将参数(parameter)给 小程序端
                // https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_4.shtml
                
            }

            return miniProgramPayDto;
        }


        /// <summary>
        /// 微信支付订单号查询
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<QueryByTransactionIdDto> QueryByTransactionIdAsync(WeChatPayQueryByTransactionIdViewModel viewModel)
        {
            QueryByTransactionIdDto queryByTransactionIdDto = new QueryByTransactionIdDto();
            var model = new WeChatPayTransactionsIdQueryModel
            {
                MchId = weChatPayOptions.MchId,
            };

            var request = new WeChatPayTransactionsIdRequest
            {
                TransactionId = viewModel.TransactionId
            };

            request.SetQueryModel(model);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            queryByTransactionIdDto.WeChatPayTransactionsIdResponse = response;

            return queryByTransactionIdDto;
        }

       
        /// <summary>
        /// 商户订单号查询
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<QueryByOutTradeNoDto> QueryByOutTradeNoAsync(WeChatPayQueryByOutTradeNoViewModel viewModel)
        {
            QueryByOutTradeNoDto queryByOutTradeNoDto = new QueryByOutTradeNoDto();
            var model = new WeChatPayTransactionsOutTradeNoQueryModel
            {
                MchId = weChatPayOptions.MchId,
            };

            var request = new WeChatPayTransactionsOutTradeNoRequest
            {
                OutTradeNo = viewModel.OutTradeNo,
            };

            request.SetQueryModel(model);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            queryByOutTradeNoDto.WeChatPayTransactionsOutTradeNoResponse = response;
            return queryByOutTradeNoDto;
        }

       

        /// <summary>
        /// 关闭订单
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<OutTradeNoCloseDto> OutTradeNoCloseAsync(WeChatPayOutTradeNoCloseViewModel viewModel)
        {
            OutTradeNoCloseDto queryByOutTradeNoCloseDto = new OutTradeNoCloseDto();
            var model = new WeChatPayTransactionsOutTradeNoCloseBodyModel
            {
                MchId = weChatPayOptions.MchId,
            };

            var request = new WeChatPayTransactionsOutTradeNoCloseRequest
            {
                OutTradeNo = viewModel.OutTradeNo,
            };

            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            queryByOutTradeNoCloseDto.WeChatPayTransactionsOutTradeNoCloseResponse = response;

            return queryByOutTradeNoCloseDto;
        }

        
        /// <summary>
        /// 申请交易账单
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<TradeBillDto> TradeBillAsync(WeChatPayTradeBillViewModel viewModel)
        {
            TradeBillDto tradeBillDto = new TradeBillDto();
            var model = new WeChatPayBillTradeBillQueryModel
            {
                BillDate = viewModel.BillDate
            };

            var request = new WeChatPayBillTradeBillRequest();

            request.SetQueryModel(model);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            tradeBillDto.WeChatPayBillTradeBillResponse = response;

            return tradeBillDto;
        }

       

        /// <summary>
        /// 申请资金账单
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<FundflowBillDto> FundflowBillAsync(WeChatPayFundflowBillViewModel viewModel)
        {
            FundflowBillDto fundflowBillDto = new FundflowBillDto();
            var model = new WeChatPayBillFundflowBillQueryModel
            {
                BillDate = viewModel.BillDate
            };

            var request = new WeChatPayBillFundflowBillRequest();
            request.SetQueryModel(model);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            fundflowBillDto.WeChatPayBillFundflowBillResponse = response;
            
            return fundflowBillDto;
        }

        

        /// <summary>
        /// 下载账单
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<BillDownloadDto> BillDownloadAsync(WeChatPayBillDownloadViewModel viewModel)
        {
            BillDownloadDto billDownloadDto = new BillDownloadDto();
            var request = new WeChatPayBillDownloadRequest();
            request.SetRequestUrl(viewModel.DownloadUrl);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            billDownloadDto.WeChatPayBillDownloadResponse = response;

            return billDownloadDto;
        }

        /// <summary>
        /// 退款申请
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<RefundDto> RefundAsync(WeChatPayV3RefundViewModel viewModel)
        {
            RefundDto refundDto = new RefundDto();
            var model = new WeChatPayRefundDomesticRefundsBodyModel()
            {
                TransactionId = viewModel.TransactionId,
                OutTradeNo = viewModel.OutTradeNo,
                OutRefundNo = viewModel.OutRefundNo,
                NotifyUrl = viewModel.NotifyUrl,
                Amount = new RefundAmount { Refund = viewModel.RefundAmount, Total = viewModel.TotalAmount, Currency = viewModel.Currency }
            };

            var request = new WeChatPayRefundDomesticRefundsRequest();
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            refundDto.WeChatPayRefundDomesticRefundsResponse = response;

            return refundDto;
        }

       
        /// <summary>
        /// 查询单笔退款
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual async Task<RefundQueryDto> RefundQueryAsync(WeChatPayV3RefundQueryViewModel viewModel)
        {
            RefundQueryDto refundQueryDto = new RefundQueryDto();
            var request = new WeChatPayRefundDomesticRefundsOutRefundNoRequest
            {
                OutRefundNo = viewModel.OutRefundNo
            };

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            refundQueryDto.WeChatPayRefundDomesticRefundsOutRefundNoResponse = response;

            return refundQueryDto;
        }

        #region 微信支付分

       

        /// <summary>
        /// 支付分-创建支付分订单
        /// </summary>
        public virtual async Task<ServiceOrderDto> ServiceOrderAsync(WeChatPayScoreServiceOrderViewModel viewModel)
        {
            ServiceOrderDto serviceOrderDto = new ServiceOrderDto();
            var model = new WeChatPayScoreServiceOrderBodyModel
            {
                AppId = weChatPayOptions.AppId,
                ServiceId = viewModel.ServiceId,
                OutOrderNo = viewModel.OutOrderNo,
                ServiceIntroduction = viewModel.ServiceIntroduction,
                TimeRange = new TimeRange
                {
                    StartTime = viewModel.StartTime,
                    EndTime = viewModel.EndTime
                },
                RiskFund = new RiskFund
                {
                    Name = viewModel.RiskFundName,
                    Amount = viewModel.RiskFundAmount
                },
                NotifyUrl = viewModel.NotifyUrl,
                OpenId = viewModel.OpenId
            };

            var request = new WeChatPayScoreServiceOrderRequest();
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            serviceOrderDto.WeChatPayScoreServiceOrderResponse = response;
            return serviceOrderDto;
        }

        
        /// <summary>
        /// 支付分-查询支付分订单
        /// </summary>
        public virtual async Task<ServiceOrderQueryDto> ServiceOrderQueryAsync(WeChatPayScoreServiceOrderQueryViewModel viewModel)
        {
            ServiceOrderQueryDto serviceOrderQueryDto = new ServiceOrderQueryDto();
            var model = new WeChatPayScoreServiceOrderQueryModel
            {
                AppId = weChatPayOptions.AppId,
                ServiceId = viewModel.ServiceId,
                OutOrderNo = viewModel.OutOrderNo,
                QueryId = viewModel.QueryId
            };

            var request = new WeChatPayScoreServiceOrderQueryRequest();
            request.SetQueryModel(model);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            serviceOrderQueryDto.WeChatPayScoreServiceOrderQueryResponse = response;
            return serviceOrderQueryDto;
        }

        

        /// <summary>
        /// 支付分-取消支付分订单
        /// </summary>
        public virtual async Task<ServiceOrderCancelDto> ServiceOrderCancelAsync(WeChatPayScoreServiceOrderCancelViewModel viewModel)
        {
            ServiceOrderCancelDto serviceOrderCancelDto = new ServiceOrderCancelDto();
            var model = new WeChatPayScoreServiceOrderOutOrderNoCancelBodyModel
            {
                AppId = weChatPayOptions.AppId,
                ServiceId = viewModel.ServiceId,
                Reason = viewModel.Reason
            };

            var request = new WeChatPayScoreServiceOrderOutOrderNoCancelRequest
            {
                OutOrderNo = viewModel.OutOrderNo
            };
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            serviceOrderCancelDto.WeChatPayScoreServiceOrderOutOrderNoCancelResponse = response;
            return serviceOrderCancelDto;
        }

       

        /// <summary>
        /// 支付分-修改支付分订单金额
        /// </summary>
        public virtual async Task<ServiceOrderModifyDto> ServiceOrderModifyAsync(WeChatPayScoreServiceOrderModifyViewModel viewModel)
        {
            ServiceOrderModifyDto serviceOrderModifyDto = new ServiceOrderModifyDto();
            var model = new WeChatPayScoreServiceOrderOutOrderNoModifyBodyModel
            {
                AppId = weChatPayOptions.AppId,
                ServiceId = viewModel.ServiceId,
                PostPayments = new List<PostPayment> {
                   new PostPayment{
                       Name = viewModel.Name,
                       Amount = viewModel.Amount,
                       Count = viewModel.Count
                   }
                },
                TotalAmount = viewModel.TotalAmount,
                Reason = viewModel.Reason
            };

            var request = new WeChatPayScoreServiceOrderOutOrderNoModifyRequest
            {
                OutOrderNo = viewModel.OutOrderNo
            };
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            serviceOrderModifyDto.WeChatPayScoreServiceOrderOutOrderNoModifyResponse = response;
            return serviceOrderModifyDto;
        }

       

        /// <summary>
        /// 支付分-完结支付分订单
        /// </summary>
        public virtual async Task<ServiceOrderCompleteDto> ServiceOrderCompleteAsync(WeChatPayScoreServiceOrderCompleteViewModel viewModel)
        {
            ServiceOrderCompleteDto serviceOrderCompleteDto = new ServiceOrderCompleteDto();
            var model = new WeChatPayScoreServiceOrderOutOrderNoCompleteBodyModel
            {
                AppId = weChatPayOptions.AppId,
                ServiceId = viewModel.ServiceId,
                PostPayments = new List<PostPayment>
                {
                   new PostPayment
                   {
                       Name = viewModel.Name,
                       Amount = viewModel.Amount,
                       Count = viewModel.Count
                   }
                },
                TotalAmount = viewModel.TotalAmount
            };

            var request = new WeChatPayScoreServiceOrderOutOrderNoCompleteRequest
            {
                OutOrderNo = viewModel.OutOrderNo
            };
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            serviceOrderCompleteDto.WeChatPayScoreServiceOrderOutOrderNoCompleteResponse = response;
            return serviceOrderCompleteDto;
        }

        

        /// <summary>
        /// 支付分-商户发起催收扣款
        /// </summary>
        public virtual async Task<ServiceOrderPayDto> ServiceOrderPayAsync(WeChatPayScoreServiceOrderPayViewModel viewModel)
        {
            ServiceOrderPayDto serviceOrderPayDto = new ServiceOrderPayDto();
            var model = new WeChatPayScoreServiceOrderPayBodyModel
            {
                AppId = weChatPayOptions.AppId,
                ServiceId = viewModel.ServiceId,
            };

            var request = new WeChatPayScoreServiceOrderPayRequest
            {
                OutOrderNo = viewModel.OutOrderNo
            };
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            serviceOrderPayDto.WeChatPayScoreServiceOrderPayResponse = response;
            return serviceOrderPayDto;
        }

      
        /// <summary>
        /// 支付分-同步服务订单信息
        /// </summary>
        public virtual async Task<ServiceOrderSyncDto> ServiceOrderSyncAsync(WeChatPayScoreServiceOrderSyncViewModel viewModel)
        {
            ServiceOrderSyncDto serviceOrderSyncDto = new ServiceOrderSyncDto();
            var model = new WeChatPayScoreServiceOrderSyncBodyModel
            {
                AppId = weChatPayOptions.AppId,
                ServiceId = viewModel.ServiceId,
                Type = viewModel.Type,
                Detail = new SyncDetail
                {
                    PaidTime = viewModel.PaidTime
                }
            };

            var request = new WeChatPayScoreServiceOrderSyncRequest
            {
                OutOrderNo = viewModel.OutOrderNo
            };
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            serviceOrderSyncDto.WeChatPayScoreServiceOrderSyncResponse = response;
            return serviceOrderSyncDto;
        }

        

        /// <summary>
        /// 支付分-创单结单合并
        /// </summary>
        public virtual async Task<ServiceOrderDirectCompleteDto> ServiceOrderDirectCompleteAsync(WeChatPayScoreServiceOrderDirectCompleteViewModel viewModel)
        {
            ServiceOrderDirectCompleteDto serviceOrderDirectCompleteDto = new ServiceOrderDirectCompleteDto();
            var model = new WeChatPayScoreServiceOrderDirectCompleteBodyModel
            {
                AppId = weChatPayOptions.AppId,
                ServiceId = viewModel.ServiceId,
                OutOrderNo = viewModel.OutOrderNo,
                ServiceIntroduction = viewModel.ServiceIntroduction,
                PostPayments = new List<PostPayment> {
                   new PostPayment{
                       Name = viewModel.PostPaymentName,
                       Amount = viewModel.PostPaymentAmount,
                       Description = viewModel.PostPaymentDescription,
                       Count = viewModel.PostPaymentCount
                   }
                },
                TimeRange = new TimeRange
                {
                    StartTime = viewModel.StartTime,
                    EndTime = viewModel.EndTime
                },
                TotalAmount = viewModel.TotalAmount,
                NotifyUrl = viewModel.NotifyUrl,
                OpenId = viewModel.OpenId
            };

            var request = new WeChatPayScoreServiceOrderDirectCompleteRequest();
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            serviceOrderDirectCompleteDto.WeChatPayScoreServiceOrderDirectCompleteResponse = response;
            return serviceOrderDirectCompleteDto;
        }

        

        /// <summary>
        /// 支付分-商户预授权
        /// </summary>
        public virtual async Task<PermissionsDto> PermissionsAsync(PermissionsViewModel viewModel)
        {
            PermissionsDto permissionsDto = new PermissionsDto();
            var model = new WeChatPayScorePermissionsBodyModel
            {
                AppId = weChatPayOptions.AppId,
                ServiceId = viewModel.ServiceId,
                AuthorizationCode = viewModel.AuthorizationCode,
                NotifyUrl = viewModel.NotifyUrl
            };

            var request = new WeChatPayScorePermissionsRequest();
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            permissionsDto.WeChatPayScorePermissionsResponse = response;
            return permissionsDto;
        }

        

        /// <summary>
        /// 支付分-查询用户授权记录（授权协议号）
        /// </summary>
        public virtual async Task<PermissionsQueryForAuthCodeDto> PermissionsQueryForAuthCodeAsync(PermissionsQueryForAuthCodeViewModel viewModel)
        {
            PermissionsQueryForAuthCodeDto permissionsQueryForAuthCodeDto = new PermissionsQueryForAuthCodeDto();
            var model = new WeChatPayScorePermissionsQueryForAuthCodeQueryModel
            {
                ServiceId = viewModel.ServiceId,
            };

            var request = new WeChatPayScorePermissionsQueryForAuthCodeRequest
            {
                AuthorizationCode = viewModel.AuthorizationCode
            };
            request.SetQueryModel(model);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            permissionsQueryForAuthCodeDto.WeChatPayScorePermissionsQueryForAuthCodeResponse = response;
            return permissionsQueryForAuthCodeDto;
        }

      

        /// <summary>
        /// 支付分-解除用户授权关系（授权协议号）
        /// </summary>
        public virtual async Task<PermissionsTerminateForAuthCodeDto> PermissionsTerminateForAuthCodeAsync(PermissionsTerminateForAuthCodeViewModel viewModel)
        {
            PermissionsTerminateForAuthCodeDto permissionsTerminateForAuthCodeDto = new PermissionsTerminateForAuthCodeDto();
            var model = new WeChatPayScorePermissionsTerminateForAuthCodeBodyModel
            {
                ServiceId = viewModel.ServiceId,
                Reason = viewModel.Reason
            };

            var request = new WeChatPayScorePermissionsTerminateForAuthCodeRequest
            {
                AuthorizationCode = viewModel.AuthorizationCode
            };
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            permissionsTerminateForAuthCodeDto.WeChatPayScorePermissionsTerminateForAuthCodeResponse= response;
            return permissionsTerminateForAuthCodeDto;
        }

      
        /// <summary>
        /// 支付分-查询用户授权记录（openid）
        /// </summary>
        public virtual async Task<PermissionsQueryForOpenIdDto> PermissionsQueryForOpenIdAsync(PermissionsQueryForOpenIdViewModel viewModel)
        {
            PermissionsQueryForOpenIdDto permissionsQueryForOpenIdDto = new PermissionsQueryForOpenIdDto();
            var model = new WeChatPayScorePermissionsQueryForOpenIdQueryModel
            {
                AppId = weChatPayOptions.AppId,
                ServiceId = viewModel.ServiceId,
            };

            var request = new WeChatPayScorePermissionsQueryForOpenIdRequest
            {
                OpenId = viewModel.OpenId
            };
            request.SetQueryModel(model);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            permissionsQueryForOpenIdDto.WeChatPayScorePermissionsQueryForOpenIdResponse= response;
            return permissionsQueryForOpenIdDto;
        }

       

        /// <summary>
        /// 支付分-解除用户授权关系（OpenId）
        /// </summary>
        public virtual async Task<PermissionsTerminateForOpenIdDto> PermissionsTerminateForOpenIdAsync(PermissionsTerminateForOpenIdViewModel viewModel)
        {
            PermissionsTerminateForOpenIdDto permissionsTerminateForOpenIdDto= new PermissionsTerminateForOpenIdDto();
            var model = new WeChatPayScorePermissionsTerminateForOpenIdBodyModel
            {
                AppId = weChatPayOptions.AppId,
                ServiceId = viewModel.ServiceId,
                Reason = viewModel.Reason
            };

            var request = new WeChatPayScorePermissionsTerminateForOpenIdRequest
            {
                OpenId = viewModel.OpenId
            };
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, weChatPayOptions);
            permissionsTerminateForOpenIdDto.WeChatPayScorePermissionsTerminateForOpenIdResponse = response;
            return permissionsTerminateForOpenIdDto;
        }

        #endregion
    }
}
