using Spacetur.Model;
using Microsoft.EntityFrameworkCore;

namespace Spacetur.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Usuario entity
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(u => u.Id);
                entity.Property(u => u.Nome).IsRequired().HasMaxLength(250);
                entity.Property(u => u.Cpf).IsRequired().HasMaxLength(11);
                entity.Property(u => u.Email).IsRequired().HasMaxLength(250);
                entity.Property(u => u.Senha).IsRequired().HasMaxLength(250);
                entity.Property(u => u.Telefone).HasMaxLength(20);
                entity.Property(u => u.Destino).HasMaxLength(250);

                // Seed initial data
                entity.HasData(
                    new Usuario
                    {
                        Id = 1,
                        Nome = "Marcos",
                        Cpf = "965478",
                        Email = "marcos@gmail.com",
                        Senha = "123456",
                        Telefone = "31-99999-9999",
                        Destino = "Lua",
                        // Add other properties as needed
                    },
                    new Usuario
                    {
                        Id = 2,
                        Nome = "nayara",
                        Cpf = "98756322",
                        Email = "nayara@gmail.com",
                        Senha = "123456",
                        Telefone = "31-99999-9988",
                        Destino = "Marte",
                        // Add other properties as needed
                    }
                    // Add more seed data as needed
                );
            });
        }
    }
}
