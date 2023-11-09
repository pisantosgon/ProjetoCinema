using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCinema.Models
{
    public class Filme
    {
        [Column("FilmesId")]
        [Display(Name = "Codigo do Filme")]
        public int Id { get; set; }

        [Column("FilmeNome")]
        [Display(Name = "Filme")]
        public string FilmeNome { get; set; } = string.Empty;

        [Column("Idade")]
        [Display(Name = "Classificação Indicativa")]
        public int Idade { get; set; }

        [Column("SesssaoHora")]
        [Display(Name = "Horário da Sessão")]

        public DateTime SesssaoHora { get; set; }

        [NotMapped]
        [Display(Name = "Filme e Sessão")]
        public string DescricaoCadastro => FilmeNome + " | " + SesssaoHora.ToString();
    }
}
