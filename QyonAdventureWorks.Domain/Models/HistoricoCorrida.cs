namespace QyonAdventureWorks.Domain.Models
{
    public class HistoricoCorrida
    {
        public HistoricoCorrida()
        {

        }
        public virtual int Id { get; set; }
        public virtual int CompetidorId { get; set; }
        public virtual int PistaCorridaId { get; set; }
        public virtual DateTime DataCorrida { get; set; }
        public virtual decimal TempoGasto { get; set; }

    }
}