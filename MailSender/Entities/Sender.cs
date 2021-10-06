using System.ComponentModel.DataAnnotations;

namespace MailSender.Entities
{
    public class Sender
    {
        [Key]
        public string EmailAddres { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}