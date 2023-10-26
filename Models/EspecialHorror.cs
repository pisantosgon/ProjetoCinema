using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCinema.Models
{
    public class EspecialHorror
    {

        [Column("HorrorId")]
        [Display(Name = "Codigo do Horror")]
        public int Id { get; set; }

        [Column("Filmes")]
        [Display(Name = "Filmes")]
        public string Filmes { get; set; } = string.Empty;

        [Column("Classificacao")]
        [Display(Name = "Classificação Indicativa")]
        public int Classificacao { get; set; } 

        [Column("HrSesssao")]
        [Display(Name = "Horário da Sessão")]

        public DateTime HrSesssao { get; set; } 

    }
}
