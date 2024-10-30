using EsperancaSobreRodasAPI.Data.Map;
using EsperancaSobreRodasAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EsperancaSobreRodasAPI.Data
{
    public class EsperancaSobreRodasDBContext : DbContext
    {
        public EsperancaSobreRodasDBContext(DbContextOptions<EsperancaSobreRodasDBContext> options) : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<MotoristaModel> Motoristas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new MotoristaMap());
        }
    }
}
