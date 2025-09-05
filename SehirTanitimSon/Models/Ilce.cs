using System.ComponentModel.DataAnnotations;

namespace SehirTanitimSon.Models
{
    public class Ilce
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "İlçe adı zorunludur.")]
        public string Ad { get; set; }

        [StringLength(300, ErrorMessage = "Açıklama en fazla 300 karakter olabilir.")]
        public string Aciklama { get; set; }
    }
}
