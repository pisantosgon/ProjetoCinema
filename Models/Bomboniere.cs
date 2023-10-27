using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCinema.Models
{
    public class Bomboniere
    {
        [Column("BomboniereId")]
        [Display(Name = "Codigo do Bomboniere")]
        public int Id { get; set; }

        [ForeignKey("CategoriaId")]
        [Display(Name = "Codigo da Categoria")]
        public int CategoriaId { get; set; }

        public Categoria? Categoria { get; set; }

        [Column("NomeProduto")]
        [Display(Name = "Nome do Produto")]
        public string NomeProduto { get; set; } = string.Empty;

        [Column("DescricaoProduto")]
        [Display(Name = "Descrição")]

        public string DescricaoProduto { get; set; } = string.Empty;

        [Column("TamanhoProduto")]
        [Display(Name = "Tamanho/Quantidade")]

        public string TamanhoProduto { get; set; } = string.Empty;

        [Column("PrecoProduto")]
        [Display(Name = "Preço")]

        public string PrecoProduto { get; set; } = string.Empty;
    }
}
