using Microsoft.EntityFrameworkCore;

namespace Beach_Report.Data
{
    public class BeachContext : DbContext
    {
        public BeachContext(DbContextOptions<BeachContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Reportar> Reportars { get; set; }

        public DbSet<Descricao> Descricoes { get; set; }


    }
}
