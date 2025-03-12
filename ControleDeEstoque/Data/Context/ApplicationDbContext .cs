using ControleDeEstoque.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using SuiteMartinelli.Module.Data.Mapping.GlobalMap;

namespace ControleDeEstoque.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UsuariosMap());
        }
    }
}
