using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCinema.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Column("CategoriaId")]
        [Display(Name = "Codigo da Categoria")]
        public int Id { get; set; }

        [Column("CategoriaNome")]
        [Display(Name = "Nome da Categoria")]
        public string CategoriaNome { get; set; } = string.Empty;
    }
}
