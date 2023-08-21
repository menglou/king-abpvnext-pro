using MimeKit;
using System;
using System.Collections.Generic;
using System.Text;

namespace King.AbpVnextPro.Core.King.AbpVnextPro.Core
{
    public  class MailKitHelper
    {
        /// <summary>
        ///发送邮件
        /// </summary>
        /// <param name="smtpServer">服务器地址</param>
        /// <param name="smtpPort">服务器端口号</param>
        /// <param name="fromAccount">发送人账户</param>
        /// <param name="fromAccountPwd">发送人密码</param>
        /// <param name="fromAccountName">发送人名称</param>
        /// <param name="toAddressList">接收人(可以是多个)</param>
        /// <param name="title">标题</param>
        /// <param name="content">内容</param>
        /// <param name="attachments">附件</param>
        /// <returns></returns>
        public static void SendMail(string smtpServer,int smtpPort,string fromAccount,string fromAccountPwd, string fromAccountName,  List<KeyValuePair<string, string>> toAddressList, string title, string content, List<KeyValuePair<string, byte[]>> attachments = null)
        {
            var mailMessage = new MimeMessage();
            var fromMailAddress = new MailboxAddress(fromAccountName, fromAccount);
            mailMessage.From.Add(fromMailAddress);
            var toMailAddress = toAddressList.Select(x => new MailboxAddress(x.Key, x.Value));
            mailMessage.To.AddRange(toMailAddress);

            var bodyBuilder = new BodyBuilder() { HtmlBody = content };
            if (attachments != null)
            {
                foreach (var item in attachments)
                {
                    bodyBuilder.Attachments.Add(item.Key, item.Value);
                }
            }
            mailMessage.Body = bodyBuilder.ToMessageBody();
            mailMessage.Subject = title;
            using (var smtpClient = new MailKit.Net.Smtp.SmtpClient())
            {
                smtpClient.Timeout = 10 * 1000;   //设置超时时间
                smtpClient.Connect(smtpServer, smtpPort, MailKit.Security.SecureSocketOptions.Auto);//连接到远程smtp服务器
                smtpClient.Authenticate(fromAccount, fromAccountPwd);
                smtpClient.Send(mailMessage);//发送邮件
                smtpClient.Disconnect(true);
            }
        }
    }
}
