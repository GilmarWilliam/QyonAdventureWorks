using Microsoft.EntityFrameworkCore;
using QyonAdventureWorks.Domain.Models;
using QyonAdventureWorks.Domain.Repositories;
using QyonAdventureWorks.Infra.Config;

namespace QyonAdventureWorks.Infra.Repositories
{
    public class HistoricoCorridaRepository : IHistoricoCorridaRepository
    {
        private readonly ContextBase _dbContext;

        public HistoricoCorridaRepository(ContextBase contextBase)
        {
            _dbContext = contextBase;
        }

        public async Task<HistoricoCorrida> GetHistoricoCorridaById(int id)
        {
            return await _dbContext.HistoricoCorrida.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<HistoricoCorrida>> GetHistoricoCorrida()
        {
            return await _dbContext.HistoricoCorrida.ToListAsync();
        }

        public async Task<HistoricoCorrida> CreateHistoricoCorrida(HistoricoCorrida historicoCorrida)
        {
            await _dbContext.HistoricoCorrida.AddAsync(historicoCorrida);
            await _dbContext.SaveChangesAsync();
            return historicoCorrida;
        }

        public async Task<HistoricoCorrida> UpdateHistoricoCorrida(HistoricoCorrida historicoCorrida)
        {
            HistoricoCorrida historicoCorridaPorId = await GetHistoricoCorridaById(historicoCorrida.Id);
            if (historicoCorridaPorId == null)
                throw new ArgumentNullException($"User ID:{historicoCorrida.Id} not found");

            historicoCorridaPorId.CompetidorId = historicoCorrida.CompetidorId;
            historicoCorridaPorId.PistaCorridaId = historicoCorrida.PistaCorridaId;
            historicoCorridaPorId.DataCorrida = historicoCorrida.DataCorrida;
            historicoCorridaPorId.TempoGasto = historicoCorrida.TempoGasto;

            _dbContext.HistoricoCorrida.Update(historicoCorridaPorId);
            await _dbContext.SaveChangesAsync();

            return historicoCorridaPorId;
        }
    }
}