using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.Entities
{
    class Remittee
    {
        public int CNPJ { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string EmailAddressII { get; set; }
        public string EmailAddressIII { get; set; }
        public string EmailAddressIV { get; set; }
        public string EmailAddressV { get; set; }
    }
}
