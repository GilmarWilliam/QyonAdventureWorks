namespace QyonAdventureWorks.Domain.Models
{
    public class Competidor
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual char Sexo { get; set; }
        public virtual decimal TemperaturaMediaCorpo { get; set; }
        public virtual decimal Peso { get; set; }
        public virtual decimal Altura { get; set; }
        public virtual IEnumerable<HistoricoCorrida> HistoricoCorridas { get; set; }

        public Competidor(int id, string nome, char sexo, decimal temperaturaMediaCorpo, decimal peso, decimal altura)
        {
            Id = id;
            Nome = nome;
            Sexo = sexo;
            TemperaturaMediaCorpo = temperaturaMediaCorpo;
            Peso = peso;
            Altura = altura;
            HistoricoCorridas = new List<HistoricoCorrida>();
        }
    }
}