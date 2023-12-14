using Agencia_de_Recrutamento.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agencia_de_Recrutamento.Repository.Mapping
{
    public class RecrutadorMap : IEntityTypeConfiguration<Recrutador>
    {
        public void Configure(EntityTypeBuilder<Recrutador> builder)
        {
            builder.ToTable("Recrutador");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Login)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Senha)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Email)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Ativo);
        }
    }
}
