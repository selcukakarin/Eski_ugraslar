using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCBlog.Data
{
    public class Makale
    {
        public int MakaleId { get; set; }

        [Required(ErrorMessage = "Lütfen makalenin başlığını giriniz.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Makale başlığını 3-50 karakter arası giriniz.")]
        public string Baslik { get; set; }

        [Required(ErrorMessage = "Lütfen makalenin içeriğini giriniz.")]
        [DataType(DataType.Html, ErrorMessage = "Lütfen makale içeriğini html formatında giriniz")]
        public string Icerik { get; set; }

        [Required(ErrorMessage = "Lütfen makale eklenme tarihini giriniz.")]
        [DataType(DataType.DateTime, ErrorMessage = "Lütfen makale eklenme tarihini doğru giriniz")]
        public DateTime Tarih { get; set; }

        public virtual Uye Uye { get; set; }

        public virtual List<Yorum> Yorums { get; set; }

        public virtual List<Etiket> Etikets { get; set; }

    }
}