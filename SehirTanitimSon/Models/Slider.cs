using System.ComponentModel.DataAnnotations;

namespace SehirTanitimSon.Models
{
    public class Slider
    {
        public int Id { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public string Title { get; set; }

        public string Description { get; set; } // Bu satır İstanbul tanıtımı için şart
    }
}
