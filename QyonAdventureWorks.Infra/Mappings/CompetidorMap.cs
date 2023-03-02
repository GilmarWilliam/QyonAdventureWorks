using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QyonAdventureWorks.Domain.Models;

namespace QyonAdventureWorks.Infra.Mappings
{
    public class CompetidorMap : IEntityTypeConfiguration<Competidor>
    {
        public void Configure(EntityTypeBuilder<Competidor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x=>x.Sexo).IsRequired();
            builder.Property(x=>x.TemperaturaMediaCorpo).IsRequired();
            builder.Property(x => x.Peso).IsRequired();
            builder.Property(x=>x.Altura).IsRequired();
        }
    }
}