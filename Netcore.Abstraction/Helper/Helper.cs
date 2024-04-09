using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Netcore.Abstraction.Helper
{
    public class Helper
    {
        public static void SendMail(string to, string subject, string body)
        {
            MailMessage message = new MailMessage();
         
            message.From = new MailAddress("applicationserver@icastellano.cl");
            message.To.Add(to);
            message.Subject = subject;
            message.Body = body;
            message.IsBodyHtml = false;
            message.Priority = MailPriority.Normal;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("applicationserver@icastellano.cl", "insignia", "");
            smtp.Send(message);
        }

        private static char GetDigit(int body)
        {
            int counter = 0;
            int multiple = 2;

            while (body != 0)
            {
                counter += (body % 10) * multiple;

                body /= 10;

                multiple++;

                if (multiple == 8) multiple = 2;
            }

            counter = 11 - (counter % 11);

            if (counter == 10)
            {
                return 'K';
            }
            else if (counter == 11)
            {
                return '0';
            }
            else
            {
                return char.Parse(counter.ToString());
            }
        }

        public static bool ValidateRut(int runbody, string runDigito)
        {
            return Helper.GetDigit(runbody).ToString().ToLower().Equals(runDigito.ToString().ToLower());
        }
    }
}