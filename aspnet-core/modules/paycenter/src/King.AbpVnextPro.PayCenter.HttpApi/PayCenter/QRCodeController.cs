using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King.AbpVnextPro.PayCenter.PayCenter
{
    [Authorize]
    [ControllerName("QRCode")]
    [Area("QRCode")]
    [Route("/api/qrCode")]
    public class QRCodeController:PayCenterController
    {
        /// <summary>
        /// 生成二维码SVG
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="size">尺寸</param>
        [HttpGet]
        public virtual IActionResult GetQRCode(string data)
        {
            using (var qrGenerator = new QRCodeGenerator())
            using (var qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.L))
            using (var pngByteQrCode = new PngByteQRCode(qrCodeData))
            {
                var pngBytes = pngByteQrCode.GetGraphic(20, false);
                return File(pngBytes, "image/png");
            }
        }
    }
}
