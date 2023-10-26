using Microsoft.EntityFrameworkCore;
using ProjetoCinema.Models;

namespace ProjetoCinema.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<ProjetoCinema.Models.Cadastro>? Cadastro { get; set; }
        public DbSet<ProjetoCinema.Models.EspecialHorror>? EspecialHorror { get; set; }

    }
}
