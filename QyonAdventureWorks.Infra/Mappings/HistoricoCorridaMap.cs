using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QyonAdventureWorks.Domain.Models;

namespace QyonAdventureWorks.Infra.Mappings
{
    public class HistoricoCorridaMap : IEntityTypeConfiguration<HistoricoCorrida>
    {
        public void Configure(EntityTypeBuilder<HistoricoCorrida> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CompetidorId).IsRequired();
            builder.Property(x => x.PistaCorridaId).IsRequired();
            builder.Property(x => x.DataCorrida).IsRequired();
            builder.Property(x => x.TempoGasto).IsRequired();
        }
    }
}