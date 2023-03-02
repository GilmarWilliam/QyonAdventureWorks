using QyonAdventureWorks.Domain.Models;

namespace QyonAdventureWorks.Domain.Repositories
{
    public interface IPistaCorridaRepository
    {
        Task<PistaCorrida> GetPistaCorridaById(int id);

        Task<List<PistaCorrida>> GetPistaCorrida();

        Task<PistaCorrida> CreatePistaCorrida(PistaCorrida pistaCorrida);

        Task<PistaCorrida> UpdatePistaCorrida(PistaCorrida pistaCorrida);

        Task<bool> DeletePistaCorrida(int id);
    }
}