using EsperancaSobreRodasAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EsperancaSobreRodasAPI.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NomePaciente);
            builder.Property(x => x.TipoUsuario).IsRequired();
            builder.Property(x => x.NomeUsuario).IsRequired();
            builder.Property(x => x.SenhaUsuario).IsRequired();
            builder.Property(x => x.TelefoneUsuario).IsRequired();
        }
    }
}
