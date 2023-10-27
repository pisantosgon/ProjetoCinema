using Microsoft.EntityFrameworkCore;
using ProjetoCinema.Models;

namespace ProjetoCinema.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Cadastro>? Cadastro { get; set; }

        public DbSet<Bomboniere>? Bomboniere { get; set; }

        public DbSet<Filme>? Filme { get; set; }

        public DbSet<EspecialHorror>? EspecialHorror { get; set; }

        public DbSet<Categoria>? Categoria { get; set; }



    }
}
