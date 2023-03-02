namespace QyonAdventureWorks.Domain.Models
{
    public class PistaCorrida
    {
        public virtual int Id { get; set; }
        public virtual string Descricao { get; set; }
        public virtual IEnumerable<HistoricoCorrida> HistoricoCorridas { get; set; }

        public PistaCorrida(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
            HistoricoCorridas = new List<HistoricoCorrida>();
        }
    }
}