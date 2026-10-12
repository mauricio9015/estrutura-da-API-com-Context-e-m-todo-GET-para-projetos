using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Exo.WebApi.Contexts
{
    // Context: cuida da conexão com o banco de dados (Entity Framework Core).
    public class ExoContext : DbContext
    {
        public ExoContext()
        {
        }

        public ExoContext(DbContextOptions<ExoContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Essa string de conexão depende da SUA máquina (autenticação do Windows).
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;"
                    + "Database=ExoApi;Trusted_Connection=True;");

                // Exemplo 1 de string de conexão (usuário sa):
                // "User ID=sa;Password=admin;Server=localhost;Database=ExoApi;Trusted_Connection=False;"

                // Exemplo 2 de string de conexão (autenticação do Windows):
                // "Server=localhost\\SQLEXPRESS;Database=ExoApi;Trusted_Connection=True;"
                //
                // Se o SQL Server 2022 reclamar de certificado SSL, acrescente ao final: TrustServerCertificate=True;
            }
        }

        // Cada DbSet representa uma tabela do banco.
        public DbSet<Projeto> Projetos { get; set; }
    }
}
