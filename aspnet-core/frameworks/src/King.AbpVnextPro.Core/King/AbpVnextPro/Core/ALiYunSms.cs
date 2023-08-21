

namespace King.AbpVnextPro.Core.King.AbpVnextPro.Core
{
    public class ALiYunSms
    {
        /// <summary>
        /// 阿里云--发送短信
        /// </summary>
        /// <param name="ACCESSKEYID">如：LTAI4Fr2FDUGtKqNR8MPAYVB，参考阿里云短信开发者文档</param>
        /// <param name="ACCESSSECRET">如：Qy1gS1FFENHUkLpTH7c0r3hLBxRuAb，参考阿里云短信开发者文档</param>
        /// <param name="domain">如：dysmsapi.aliyuncs.com，参考阿里云短信开发者文档</param>
        /// <param name="version">如：版本号：2017-05-25，参考阿里云短信开发者文档</param>
        /// <param name="signName">如：华控二供，参考阿里云短信开发者文档</param>
        /// <param name="mobiles">接收手机列表1000个</param>
        /// <param name="jsonParam">Json格式的参数，名称需匹配模板</param>
        /// <param name="templateCode">模版CODE, 如：SMS_180355519为报警模板</param>
        /// <returns></returns>
        public static string SendSms(string ACCESSKEYID,  string ACCESSSECRET, string domain,string version,string signName, List<string> mobiles, string jsonParam, string templateCode)
        {
            string SendResult = string.Empty;

            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", ACCESSKEYID, ACCESSSECRET);
            DefaultAcsClient client = new DefaultAcsClient(profile);
            CommonRequest request = new CommonRequest();
            request.Method = MethodType.POST;
            request.Domain = domain;
            request.Version = version;
            request.Action = "SendSms";
            request.AddQueryParameters("PhoneNumbers", string.Join(",", mobiles.ToArray()));
            request.AddQueryParameters("SignName", signName);
            request.AddQueryParameters("TemplateCode", templateCode);
            request.AddQueryParameters("TemplateParam", jsonParam);
            try
            {
                CommonResponse response = client.GetCommonResponse(request);
                string content = Encoding.Default.GetString(response.HttpResponse.Content);

                if (string.IsNullOrEmpty(content) == false)
                {
                    SmsResponse smsResponse =JsonSerializer.Deserialize<SmsResponse>(content);
                    if (smsResponse != null && smsResponse.Code == "OK")
                    {
                        SendResult = "OK";
                    }
                }
            }
            catch (ServerException e)
            {
                SendResult = e.Message;
            }
            catch (ClientException e)
            {
                SendResult = e.Message;
            }
            return SendResult;
        }
    }


    class SmsResponse
    {
        public string RequestId { get; set; }

        public string Message { get; set; }

        public string BizId { get; set; }

        public string Code { get; set; }
    }
}
