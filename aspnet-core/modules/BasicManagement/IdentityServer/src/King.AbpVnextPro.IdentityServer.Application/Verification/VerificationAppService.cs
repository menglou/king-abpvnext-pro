using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Caching;

namespace King.AbpVnextPro.IdentityServer.Verification
{
    [RemoteService(false)]
    public class VerificationAppService : IdentityServerAppService, IVerificationAppService
    {
        private readonly IDistributedCache<string> _verifyCodecache;

        public VerificationAppService(IDistributedCache<string> verifyCodecache)
        {
            _verifyCodecache = verifyCodecache;
        }

        public VerifyCode GetVerificationCode()
        {
            var veryCode = CreateVerifyCode(4);

            _verifyCodecache.GetOrAdd(veryCode.Id, () => Md5(veryCode.Code.ToLower()), () => new DistributedCacheEntryOptions
            {
                AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(1)

            });
            return veryCode;
        }

       

        public  async Task<string> GetVerifyCodeMd5FromCache(string id,string code)
        {
            string result = "SUCCESS";
            var veryCodeMd5FromCache=await _verifyCodecache.GetAsync(id);
         
            if (!string.IsNullOrEmpty(veryCodeMd5FromCache))
            {
                var vericodeMd5 = Md5(code.ToLower());
                if (!vericodeMd5.ToLower().Equals(veryCodeMd5FromCache.ToLower()))
                {
                    result = "验证码输入错误请检查";
                }
            }
            else
            {
                result = "验证码已过期请重新输入";
            }
            return result;
        }

        private VerifyCode CreateVerifyCode(int n)
        {
            int codeW = 170;//宽度
            int codeH = 50;//高度
            int fontSize = 32;//字体大小

            var charCode = CreateCharCode(n);
            Color[] colors = { Color.Black, Color.Red, Color.Blue, Color.Green, Color.Orange, Color.Brown, Color.DarkBlue };
            //字体列表
            string[] fonts = { "Times New Roman", "Verdana", "Arial", "Gungsuh" };
            //创建画布
            Bitmap bitmap = new Bitmap(codeW, codeH);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            Random random = new Random();
            //画躁线
            for (int i = 0; i < n; i++)
            {
                int x1 = random.Next(codeW);
                int y1 = random.Next(codeH);
                int x2 = random.Next(codeW);
                int y2 = random.Next(codeH);
                Color color = colors[random.Next(colors.Length)];
                Pen pen = new Pen(color);
                graphics.DrawLine(pen, x1, y1, x2, y2);
            }
            //画噪点
            for (int i = 0; i < 100; i++)
            {
                int x = random.Next(codeW);
                int y = random.Next(codeH);
                Color color = colors[random.Next(colors.Length)];
                bitmap.SetPixel(x, y, color);
            }
            //画验证码
            for (int i = 0; i < n; i++)
            {
                string fontStr = fonts[random.Next(fonts.Length)];
                Font font = new Font(fontStr, fontSize);
                Color color = colors[random.Next(colors.Length)];
                graphics.DrawString(charCode[i].ToString(), font, new SolidBrush(color), (float)i * 30 + 5, (float)0);
            }
            //写入内存流
            try
            {
                MemoryStream stream = new MemoryStream();
                bitmap.Save(stream, ImageFormat.Jpeg);
                VerifyCode verifyCode = new VerifyCode()
                {
                    Id = Guid.NewGuid().ToString(),
                    Code = charCode,
                    Image = stream.ToArray()
                };
                return verifyCode;
            }
            //释放资源
            finally
            {
                graphics.Dispose();
                bitmap.Dispose();
            }


        }

        private string CreateCharCode(int n)
        {
            char[] strChar = { 'a', 'b','c','d','e','f','g','h','i','j','k','l','m',
                'n','o','p','q','r','s','t','u','v','w','x','y','z','0','1','2','3',
                '4','5','6','7','8','9','A','B','C','D','E','F','G','H','I','J','K',
                'L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};

            string charCode = string.Empty;
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                charCode += strChar[random.Next(strChar.Length)];
            }
            return charCode;
        }

        private  string Md5(string str)
        {
            //将字符串编码为字节序列
            byte[] bt = Encoding.UTF8.GetBytes(str);
            //创建默认实现的实例
            var md5 = MD5.Create();
            //计算指定字节数组的哈希值。
            var md5bt = md5.ComputeHash(bt);
            //将byte数组转换为字符串
            StringBuilder builder = new StringBuilder();
            foreach (var item in md5bt)
            {
                builder.Append(item.ToString("X2"));
            }
            string md5Str = builder.ToString();
            return builder.ToString();
        }
    }
}
