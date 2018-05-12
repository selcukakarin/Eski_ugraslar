using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCBlog.Data
{
    public class Yorum
    {
        public int YorumId { get; set; }

        [Required(ErrorMessage = "Lütfen yorum giriniz.")]
        public string Icerik { get; set; }

        [Required(ErrorMessage = "Lütfen yorum yapılma tarihini giriniz.")]
        [DataType(DataType.DataTime, ErrorMessage = "Lütfen yorum yapılma tarihini doğru giriniz.")]
        public DataTime Tarih { get; set; }

        public virtual Makale Makale { get; set; }

        public virtual Uye Uye { get; set; }

    }
}