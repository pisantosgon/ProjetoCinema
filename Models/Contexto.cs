using Microsoft.EntityFrameworkCore;

namespace ProjetoCinema.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

    }
}
