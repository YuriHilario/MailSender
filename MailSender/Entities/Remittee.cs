using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MailSender.Entities
{
    public class Remittee
    {
        [Key]        
        public string CNPJ { get; set; }
        public string Name { get; set; }
        public string UF { get; set; }
        public string EmailAddress { get; set; }
        public string EmailAddressII { get; set; }
        public string EmailAddressIII { get; set; }
        public string EmailAddressIV { get; set; }
        public string EmailAddressV { get; set; }
    }
}
