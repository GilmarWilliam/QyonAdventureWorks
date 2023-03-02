using QyonAdventureWorks.Domain.Models;

namespace QyonAdventureWorks.Domain.Repositories
{
    public interface IHistoricoCorridaRepository
    {
        Task<HistoricoCorrida> GetHistoricoCorridaById(int id);

        Task<List<HistoricoCorrida>> GetHistoricoCorrida();

        Task<HistoricoCorrida> CreateHistoricoCorrida(HistoricoCorrida historicoCorrida);

        Task<HistoricoCorrida> UpdateHistoricoCorrida(HistoricoCorrida historicoCorrida);
    }
}