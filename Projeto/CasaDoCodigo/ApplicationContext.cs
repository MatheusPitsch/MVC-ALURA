using Microsoft.EntityFrameworkCore;

namespace CasaDoCodigo.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Produto>().HasKey(l => l.Id);

            modelBuilder.Entity<Pedido>().HasKey(l => l.Id);
            modelBuilder.Entity<Pedido>().HasMany(l => l.Itens).WithOne(t => t.Pedido);
            modelBuilder.Entity<Pedido>().HasOne(l => l.Cadastro).WithOne(t => t.Pedido).IsRequired();

            modelBuilder.Entity<Cadastro>().HasKey(l => l.Id);
            modelBuilder.Entity<Cadastro>().HasOne(l => l.Pedido);
        }
    }
}