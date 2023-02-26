using LanchesMac.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        DbSet<Categoria> Categorias { get; set; }
        DbSet<Lanche> Lanches { get; set; }
    }
}
