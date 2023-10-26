using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCinema.Models
{
    public class Bomboniere
    {
        [Column("BomboniereId")]
        [Display(Name = "Codigo do Bomboniere")]
        public int Id { get; set; }

        [Column("Pipocas")]
        [Display(Name = "Pipocas")]
        public string Pipocas { get; set; } = string.Empty;

        [Column("Bebidas")]
        [Display(Name = "Bebidas")]
        public string Bebidas { get; set; } = string.Empty;

        [Column("Guloseimas")]
        [Display(Name = "Guloseimas")]

        public string Guloseimas { get; set; } = string.Empty;


    }
}
