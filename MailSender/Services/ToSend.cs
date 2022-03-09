using MailSender.Entities;
using System;
using System.IO;
using System.Net.Mail;
using System.Net.Mime;

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
            mailMessage.IsBodyHtml = true;
            mailMessage.Subject = mail.Title;
            mailMessage.Body = $"<p>{mail.Body}</p> <br/><br/><img src=\"cid:{mail.PatchImage}\" />";
            mailMessage.Priority = MailPriority.High;
            string attachmentPath = @$"{mail.PatchImage}";
            Attachment inline = new Attachment(attachmentPath);
            inline.ContentDisposition.Inline = true;
            inline.ContentDisposition.DispositionType = DispositionTypeNames.Inline;           
            inline.ContentType.MediaType = "image/png";
            inline.ContentType.Name = Path.GetFileName(attachmentPath);
            mailMessage.Attachments.Add(inline);          

            //const string fromPassword = "Ale@nd2409";

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

