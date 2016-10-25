using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Web;
using System.Net.Mail;

namespace SEGP
{
    class MailClass
    {

        public MailClass(String to,String sms,String Subject)
        {
            MailMessage mail = new MailMessage("hasikhan144@gmail.com",to,Subject,sms);
            SmtpClient clinet = new SmtpClient("smtp.gmail.com");
            clinet.Port = 587;
            clinet.Credentials = new System.Net.NetworkCredential("hasikhan144@gmail.com", "yoyohasikhan1111mhk");
            clinet.EnableSsl = true;
            clinet.Send(mail);
        }

    }
}
