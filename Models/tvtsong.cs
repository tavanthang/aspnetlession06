using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace tvtlession06.Models
{
    public class tvtsong
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="tvt: hay nhap ten tieu de")]
        [DisplayName("Tieu De")]
        public string tvtTitle { get; set; }
        [Required(ErrorMessage = "tvt: hay nhap tac gia")]
        [DisplayName("NV chinh")]
        public string tvtAuthor { get; set; }
        [Required(ErrorMessage = "tvt: hay nhap nghe si")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Ten co toi thieu 2 ky tu,toi da 50 ky tu")]
        public string tvtArtist { get; set; }
        [Required(ErrorMessage = "tvt: hay nhap nam xuat ban")]
        [RegularExpression(@"[0-9][4]", ErrorMessage = "Nhm:Nhap xuat phai co 2 ky tu so")]
        [Range(1900, 2004, ErrorMessage = "Nhm:Nam sinh trong khoang tu 1900-2004")]
        [DisplayName("Nam Sinh")]
        public int tvtYearRated { get; set; }
    }
}