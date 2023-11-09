using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ProjetoCinema.Models.Cadastro;

namespace ProjetoCinema.Models
{
    public class Cadastro
    {
        [Column("CadastroId")]
        [Display(Name = "Codigo do Cadastro")]
        public int Id { get; set; }

        [Column("ClienteNome")]
        [Display(Name = "Nome do Cliente")]
        public string ClienteNome { get; set; } = string.Empty;

        [ForeignKey("FilmeId")]
        [Display(Name = "Nome do Filme")]
        public int FilmeId { get; set; }

        public Filme? Filme { get; set; }

        [Column("Lugar")]
        [Display(Name = "Assento")]
        public string Lugar { get; set; } = string.Empty;

        [Column("Pedidos")]
        [Display(Name = "Pedidos")]
        public string Pedidos { get; set; } = string.Empty;

        [Column("Entrada")]
        [Display(Name = "Entrada")]
        public string Entrada { get; set; } = string.Empty;

        [Column("Total")]
        [Display(Name = "Valor total da compra")]
        public string Total { get; set; } = string.Empty;                  

    }
}
