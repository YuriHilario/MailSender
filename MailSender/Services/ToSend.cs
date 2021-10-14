using MailSender.Entities;
using System;
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
            if (mail.Remittee.EmailAddressII != string.Empty && mail.Remittee.EmailAddressII != null)
            {
                mailMessage.Bcc.Add(mail.Remittee.EmailAddressII);
            }
            if (mail.Remittee.EmailAddressIII != string.Empty && mail.Remittee.EmailAddressIII != null)
            {
                mailMessage.Bcc.Add(mail.Remittee.EmailAddressIII);
            }
            if (mail.Remittee.EmailAddressIV != string.Empty && mail.Remittee.EmailAddressIV != null)
            {
                mailMessage.Bcc.Add(mail.Remittee.EmailAddressIV);
            }
            if (mail.Remittee.EmailAddressV != string.Empty && mail.Remittee.EmailAddressV != null)
            {
                mailMessage.Bcc.Add(mail.Remittee.EmailAddressV);
            }
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
                Credentials = new System.Net.NetworkCredential(mail.Sender.EmailAddres, mail.Sender.Password)
            };
            smtp.Send(mailMessage);
        }
    }
}

