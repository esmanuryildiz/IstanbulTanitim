using System.ComponentModel.DataAnnotations;

namespace SehirTanitimSon.Models
{
    public class Nufus
    {
        public int Id { get; set; }

        [Required]
        public int Yil { get; set; }

        [Required]
        public int Sayi { get; set; }
    }
}
