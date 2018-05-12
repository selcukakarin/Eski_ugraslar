using System.ComponentModel.DataAnnotations;

namespace masterBlog.Models
{
    public class Iletisim
    {
        [Key]
        public int Id { get; set; }

        public string Isim { get; set; }
        public string Email { get; set; }
        public string Mesaj { get; set; }

        public string Telefon { get; set; } 

    }
}