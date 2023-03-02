using DataAnnotationsExtensions;
using QyonAdventureWorks.Domain.CustomValidators;
using System.ComponentModel.DataAnnotations;

namespace QyonAdventureWorks.Domain.Models
{
    public class Competidor
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        [StringRange(AllowableValues = new[] { "M", "F", "O" })]
        public virtual char Sexo { get; set; }
        [Range(36, 38)]
        public virtual decimal TemperaturaMediaCorpo { get; set; }
        [Range((double)decimal.MinValue, (double)decimal.MaxValue)]
        public virtual decimal Peso { get; set; }
        [Range((double)decimal.MinValue, (double)decimal.MaxValue)]
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