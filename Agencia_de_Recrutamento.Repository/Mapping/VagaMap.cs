using Agencia_de_Recrutamento.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agencia_de_Recrutamento.Repository.Mapping
{
    public class VagaMap : IEntityTypeConfiguration<Vaga>
    {
        public void Configure(EntityTypeBuilder<Vaga> builder)
        {
            builder.ToTable("Vaga");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Titulo)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Descricao)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Formacao)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Salario)
                .IsRequired();

            builder.Property(prop => prop.DataCriacao)
                .IsRequired();

            builder.Property(prop => prop.Ativo);

            builder.HasOne(prop => prop.Empresa);

            builder.HasMany(prop => prop.Inscritos);

            builder.HasOne(prop => prop.Recrutador);

        }
    }
}
