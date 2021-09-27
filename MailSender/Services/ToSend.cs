using MailSender.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.Services
{
    class ToSend
    {
        public void _toSend()
        {
            static void EnviarEmail(Mail mail, Sender sender, Remittee remittee)
            {
                // Envio de email com descrição
                var fromAddress = new System.Net.Mail.MailAddress(sender.EmailAddres, sender.Name);
                var toAddress = new System.Net.Mail.MailAddress(remittee.EmailAddress, remittee.Name);
                const string fromPassword = "Ale@nd2409";

                var smtp = new System.Net.Mail.SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new System.Net.Mail.MailMessage(fromAddress, toAddress)
                {
                    Subject = mail.Title,
                    Body = mail.Body
                })
                {
                    smtp.Send(message);
                }
            }
        }
    }
}
