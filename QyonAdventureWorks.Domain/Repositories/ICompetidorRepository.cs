using QyonAdventureWorks.Domain.Models;

namespace QyonAdventureWorks.Domain.Repositories
{
    public interface ICompetidorRepository
    {
        Task<Competidor> GetCompetidorById(int id);

        Task<List<Competidor>> GetCompetidor();

        Task<Competidor> CreateCompetidor(Competidor competidor);

        Task<Competidor> UpdateCompetidor(Competidor competidor);

        Task<bool> DeleteCompetidor(int id);
    }
}