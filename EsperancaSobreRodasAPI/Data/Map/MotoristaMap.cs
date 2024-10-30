using EsperancaSobreRodasAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EsperancaSobreRodasAPI.Data.Map
{
    public class MotoristaMap : IEntityTypeConfiguration<MotoristaModel>
    {
        public void Configure(EntityTypeBuilder<MotoristaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NomeMotorista);
            builder.Property(x => x.NumeroPlaca).IsRequired();
            builder.Property(x => x.SenhaMotorista).IsRequired();
            builder.Property(x => x.TelefoneMotorista).IsRequired();
            builder.Property(x => x.NumeroDocumentoMotorista).IsRequired();
        }
    }
}
