using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace DMS.Web.Utils
{
    public class MailSender
    {
        public void SendMail(string subject, string body, string receivermail)
        {

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = true,
                Credentials = new NetworkCredential("hasanmukit009@gmail.com", "#Bd1971#"),
                EnableSsl = true
            };
            client.Send("hasanmukit009@gmail.com", receivermail, subject, body);
        }
    }
}
