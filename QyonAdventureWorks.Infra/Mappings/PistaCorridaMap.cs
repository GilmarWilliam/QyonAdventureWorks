using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QyonAdventureWorks.Domain.Models;

namespace QyonAdventureWorks.Infra.Mappings
{
    public class PistaCorridaMap : IEntityTypeConfiguration<PistaCorrida>
    {
        public void Configure(EntityTypeBuilder<PistaCorrida> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descricao).IsRequired();
        }
    }
}