using MailSender.Entities;
using System.Net.Mail;

namespace MailSender.Services
{
    public class ToSend
    {
        public static void _toSend(Mail mail)
        {
            // Envio de email com descrição
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(mail.Sender.EmailAddres, mail.Sender.Name);
            mailMessage.To.Add(mail.Remittee.EmailAddress);
            mailMessage.Bcc.Add(mail.Remittee.EmailAddressII);
            mailMessage.Bcc.Add(mail.Remittee.EmailAddressIII);
            mailMessage.Bcc.Add(mail.Remittee.EmailAddressIV);
            mailMessage.Bcc.Add(mail.Remittee.EmailAddressV);
            mailMessage.Subject = mail.Title;
            mailMessage.Body = mail.Body;
            
            const string fromPassword = "Ale@nd2409";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential(mail.Sender.EmailAddres, fromPassword)
            };
            smtp.Send(mailMessage);
        }
    }
}

