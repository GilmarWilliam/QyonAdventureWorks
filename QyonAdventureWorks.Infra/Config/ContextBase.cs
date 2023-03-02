using Microsoft.EntityFrameworkCore;
using QyonAdventureWorks.Domain.Models;
using QyonAdventureWorks.Infra.Mappings;

namespace QyonAdventureWorks.Infra.Config
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options) { }

        public DbSet<Competidor> Competidores { get; set; }
        public DbSet<HistoricoCorrida> HistoricoCorrida { get; set; }
        public DbSet<PistaCorrida> PistaCorrida { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompetidorMap());
            modelBuilder.ApplyConfiguration(new HistoricoCorridaMap());
            modelBuilder.ApplyConfiguration(new PistaCorridaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}