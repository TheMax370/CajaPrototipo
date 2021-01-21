
using System.Net;
using System.Net.Mail;

namespace CajaPrototipo
{
    class SendReceipt
    {
        

        //method to send email to outlook
        public static void Send_Email(string toEmail, string content)
        {

            var fromAddress = new System.Net.Mail.MailAddress("bancomantest22@gmail.com", "Cajero Automático");
            var toAddress = new System.Net.Mail.MailAddress(toEmail, "");
            const string fromPassword = "Bank1234";
            string subject = "Transacción de cajero (recibo)";
            string body = content;

            var smtp = new System.Net.Mail.SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress,toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);

                Program.log.Info("Mail Sent to email address = "+toEmail);

            }

        }

    }
}
