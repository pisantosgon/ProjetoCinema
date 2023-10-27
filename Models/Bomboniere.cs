using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCinema.Models
{
    public class Bomboniere
    {
        [Column("BomboniereId")]
        [Display(Name = "Codigo do Bomboniere")]
        public int Id { get; set; }

        [Column("CategoriaProduto")]
        [Display(Name = "Categoria")]
        public string CategoriaProduto { get; set; } = string.Empty;

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

        public int PrecoProduto { get; set; } 
    }
}
