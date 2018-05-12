using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCBlog.Data
{
    public class Uye
    {
        public int UyeId { get; set; }

        [Required(ErrorMessage = "Lütfen adınızı giriniz.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Adınızı 3-50 karakter arasında giriniz")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı giriniz")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Soyadınızı 3-50 karakter arası girin")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "Lütfen e-posta adresinizi giriniz.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Lütfen e-posta adresinizi nizami bir şekilde giriniz.")]
        public string EPosta { get; set; }

        [DataType(DataType.Url, ErrorMessage = "Lütfen web adresinizi geçerli bir formatta giriniz.")]
        public string WebSite { get; set; }

        [DataType(DataType.ImageUrl, ErrorMessage = "Lütfen resim youlunuzu doğru şekilde giriniz")]
        public string ResimYol { get; set; }

        [Required(ErrorMessage = "Lütfen üye olma tarihini giriniz.")]
        [DataType(DataType.DateTime, ErrorMessage = "Lütfen üye olma tarihini, doğru bir şekilde giriniz.")]
        public DateTime UyeOlmaTarih { get; set; }

        public virtual List<Yorum> Yorums { get; set; }

        public virtual List<Makale> Makales { get; set; }

    }
}