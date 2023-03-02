using Microsoft.EntityFrameworkCore;
using QyonAdventureWorks.Domain.Models;
using QyonAdventureWorks.Domain.Repositories;
using QyonAdventureWorks.Infra.Config;

namespace QyonAdventureWorks.Infra.Repositories
{
    public class CompetidorRepository : ICompetidorRepository
    {
        private readonly ContextBase _dbContext;

        public CompetidorRepository(ContextBase contextBase)
        {
            _dbContext = contextBase;
        }

        public async Task<Competidor> GetCompetidorById(int id)
        {
            return await _dbContext.Competidores.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Competidor>> GetCompetidor()
        {
            return await _dbContext.Competidores.ToListAsync();
        }

        public async Task<Competidor> CreateCompetidor(Competidor competidor)
        {
            await _dbContext.Competidores.AddAsync(competidor);
            await _dbContext.SaveChangesAsync();
            return competidor;
        }

        public async Task<Competidor> UpdateCompetidor(Competidor competidor)
        {
            Competidor competidorPorId = await GetCompetidorById(competidor.Id);
            if (competidorPorId == null)
                throw new ArgumentNullException($"User ID:{competidor.Id} not found");

            competidorPorId.Nome = competidor.Nome;
            competidorPorId.Sexo = competidor.Sexo;
            competidorPorId.TemperaturaMediaCorpo = competidor.TemperaturaMediaCorpo;
            competidorPorId.Peso = competidor.Peso;
            competidorPorId.Altura = competidor.Altura;

            _dbContext.Competidores.Update(competidorPorId);
            await _dbContext.SaveChangesAsync();

            return competidorPorId;
        }

        public async Task<bool> DeleteCompetidor(int id)
        {
            Competidor competidorPorId = await GetCompetidorById(id);
            if (competidorPorId == null)
                throw new ArgumentNullException($"User ID:{id} not found");

            _dbContext.Competidores.Remove(competidorPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}