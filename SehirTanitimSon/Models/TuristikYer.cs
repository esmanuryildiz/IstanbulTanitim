using System.ComponentModel.DataAnnotations;

namespace SehirTanitimSon.Models
{
    public class TuristikYer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad zorunludur.")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Açıklama zorunludur.")]
        public string Aciklama { get; set; }

        [Required(ErrorMessage = "Resim URL zorunludur.")]
        [Url(ErrorMessage = "Geçerli bir URL giriniz.")]
        public string ResimUrl { get; set; }
    }
}
