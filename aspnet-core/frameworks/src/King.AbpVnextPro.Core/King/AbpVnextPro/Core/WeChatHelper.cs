using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Settings;

namespace King.AbpVnextPro.Core.King.AbpVnextPro.Core
{
    /// <summary>
    /// 微信小程序  1,登录获取openid  2,登录获取手机号
    /// </summary>
    public class WeChatHelper
    {
        private IHttpClientFactory _httpClientFactory { get; set; }
        private ISettingProvider _settingProvider { get; set; }
        public WeChatHelper(IHttpClientFactory httpClientFactory, ISettingProvider settingProvider)
        {
            _httpClientFactory = httpClientFactory;
            _settingProvider = settingProvider;
        }

        //微信登录获取openid 
        public async Task<WxLoginResponseDto> WxLoginAuthAsync(WxLoginDto input)
        {
            var client = _httpClientFactory.CreateClient();
            string baseurl =await _settingProvider.GetOrNullAsync("WeChatLogin.LoginUrl");
            WxLoginDto wxLogin = new WxLoginDto
            {
                appid = input.appid,
                secret = input.secret,
                code = input.code,
                grant_type = input.grant_type
            };
            string url = baseurl + "?appid=" + wxLogin.appid + "&secret=" + wxLogin.secret + "&js_code=" + wxLogin.code + "&grant_type=" + wxLogin.grant_type;

            var result = await client.GetStringAsync(url);

            WxLoginResponseDto res = JsonConvert.DeserializeObject<WxLoginResponseDto>(result);
            return res;
        }
        //微信登录获取手机号
        public async Task<WxLoginPhoneResponseDto> WxLoginPhoneAsync(string code,string appid,string secret,string gettokenurl,string getuserphoneurl)
        {
            var client = _httpClientFactory.CreateClient();
          
            //湖片区access_token
            string accurl = gettokenurl + "?grant_type=" + "client_credential" + "&appid=" + appid + "&secret=" + secret;

            var accresult = await client.GetStringAsync(accurl);
            WxAccessTokenDto accessTokenDto = JsonConvert.DeserializeObject<WxAccessTokenDto>(accresult);

            //跟根据获取到的access_token 和传来的code 去获取手机号
            string url = getuserphoneurl+ "?access_token=" + accessTokenDto.access_token;

            string content = $"{{\"code\":\"{code}\"}}";
            byte[] data = Encoding.UTF8.GetBytes(content);
            var bytearray = new ByteArrayContent(data);
            var result = await client.PostAsync(url, bytearray);
            var phoneres = await result.Content.ReadAsStringAsync();
            WxLoginPhoneResponseDto res = JsonConvert.DeserializeObject<WxLoginPhoneResponseDto>(phoneres);
            return res;
        }
    }

    public class WxLoginDto
    {
        public string appid { get; set; }
        public string secret { get; set; }
        public string code { get; set; }
        public string grant_type { get; set; } = "authorization_code";
    }
    public class WxLoginResponseDto
    {
        public string openid { get; set; }
        //public string session_key { get; set; }
        public string unionid { get; set; }
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }

    public class WxLoginPhoneResponseDto
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
        public phoneinfo phone_info { get; set; }
    }

    public class phoneinfo
    {
        public string phoneNumber { get; set; }
        public string purePhoneNumber { get; set; }
        public string countryCode { get; set; }

        public watermark watermark { get; set; }
    }

    public class watermark
    {
        public int timestamp { get; set; }
        public string appid { get; set; }
    }

    public class WxAccessTokenDto 
    {
        public string access_token { get; set; }
        public decimal expires_in { get; set; }
    }
}
