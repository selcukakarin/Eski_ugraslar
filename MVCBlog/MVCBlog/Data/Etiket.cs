using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCBlog.Data
{
    public class Etiket
    {
        public int EtiketId { get;set;}
        [Required(ErrorMessage="Lütfen etiketin içeriğini giriniz.")]
        [StringLength(50,ErrorMessage="Etiketin içeriği 50 karaterden uzun olamaz.")]
        public string Icerik{get;set;}

        public virtual List<Makale> Makales{get;set;}

    }
}