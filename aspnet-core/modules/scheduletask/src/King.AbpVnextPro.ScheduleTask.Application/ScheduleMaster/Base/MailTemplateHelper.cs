using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King.AbpVnextPro.ScheduleTask.ScheduleMaster.Base
{
    public class MailTemplateHelper
    {
        public static string GetErrorEmailContent(string sname, Exception ex)
        {
            string EmailTemplate = "<div style=\"background-color:#d0d0d0;text-align:center;padding:40px;font-family:'微软雅黑','黑体', 'Lucida Grande', Verdana, sans-serif;\"><div style=\"width:700px;margin:0 auto;padding:10px;color:#333;background-color:#fff;border:0px solid #aaa;border-radius:5px;-webkit-box-shadow:3px 3px 10px #999;-moz-box-shadow:3px 3px 10px #999;box-shadow:3px 3px 10px #999;font-family:Verdana, sans-serif; \"><style> .mmsgLetterContent p { margin:20px 0; padding:0; } 	.mmsgLetterContent 	{background: url(https://imgkr.cn-bj.ufileos.com/15e4202a-3221-4af7-a315-b55220a7e119.png) no-repeat top right; }</style><div class=\"mmsgLetterContent\" style=\"text-align:left;padding:30px;font-size:14px;line-height:1.5;\"><p>你好!</p><p>感谢你使用澄水计划任务调度平台。 <br />你参与的任务<strong>$NAME$</strong>在[$TIME$] 运行发生异常，请及时查看处理。</p><p><span style = \"border-radius: 2px;background: linear-gradient(to right,#57b5e3,#c4e6f6) ;padding: 4px 6px 4px 6px;display: inline-block;line-height: 1;color: #fff;text-align: center;white-space: nowrap;vertical-align: baseline;\" > 错误信息 </span ><br /> <strong> $MESSAGE$ </strong></p><p><span style= \"border-radius: 2px ;background: linear-gradient(to right,#d73d32,#f7b5b0) ;padding: 4px 6px 4px 6px;display: inline-block;line-height: 1;color: #fff;text-align: center;white-space: nowrap;vertical-align: baseline;\" > 程序堆栈 </span><br /><span style= \"font-family: Consolas,'Courier New',Courier,FreeMono,monospace;\" >$STACKREACE$</span></p></div></div></div> ";
            return EmailTemplate.Replace("$NAME$", sname).Replace("$TIME$", DateTime.Now.ToString()).Replace("$MESSAGE$", ex.Message).Replace("$STACKREACE$", ex.StackTrace);
        }
    }
}
