using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {
        }
        public ExoContext(DbContextOptions <ExoContext> options) : base(options)
        {
        }
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Esta string depende da sua maquina
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;" +
                                            "User ID=sa;Password=12345;" +
                                            "Database=ExoApi;" +
                                            "Trusted_Connection=false;");
                // Exemplo 1 de string de conexão: 
                // User    
                // ID=sa;Password=admin;Server=localhost;Database=ExoApi;-
                // + Trusted_Connection = false;
                //
                // Exeplo 2 de string de conecção:
                // Server=localhost\\SQLEXPRESS;Database=ExoApi;Trusted_Connection=True

            }
        }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}


