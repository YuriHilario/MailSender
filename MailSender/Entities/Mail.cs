using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.Entities
{
    public class Mail
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime SendDate { get; set; }
        public Sender Sender { get; set; }
        public Remittee Remittee { get; set; }
        public string Body { get; set; }
    }
}
