using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string MailAdress { get; set; }
        public int Password { get; set; }
    }
}
