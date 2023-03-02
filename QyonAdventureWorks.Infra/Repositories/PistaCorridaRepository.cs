using Microsoft.EntityFrameworkCore;
using QyonAdventureWorks.Domain.Models;
using QyonAdventureWorks.Domain.Repositories;
using QyonAdventureWorks.Infra.Config;

namespace QyonAdventureWorks.Infra.Repositories
{
    public class PistaCorridaRepository : IPistaCorridaRepository
    {
        private readonly ContextBase _dbContext;

        public PistaCorridaRepository(ContextBase contextBase)
        {
            _dbContext = contextBase;
        }

        public async Task<PistaCorrida> GetPistaCorridaById(int id)
        {
            return await _dbContext.PistaCorrida.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<PistaCorrida>> GetPistaCorrida()
        {
            return await _dbContext.PistaCorrida.ToListAsync();
        }

        public async Task<PistaCorrida> CreatePistaCorrida(PistaCorrida pistaCorrida)
        {
            await _dbContext.PistaCorrida.AddAsync(pistaCorrida);
            await _dbContext.SaveChangesAsync();
            return pistaCorrida;
        }

        public async Task<PistaCorrida> UpdatePistaCorrida(PistaCorrida pistaCorrida)
        {
            PistaCorrida pistaCorridaPorId = await GetPistaCorridaById(pistaCorrida.Id);
            if (pistaCorridaPorId == null)
                throw new ArgumentNullException($"User ID:{pistaCorrida.Id} not found");

            pistaCorridaPorId.Descricao = pistaCorrida.Descricao;

            _dbContext.PistaCorrida.Update(pistaCorridaPorId);
            await _dbContext.SaveChangesAsync();

            return pistaCorridaPorId;
        }

        public async Task<bool> DeletePistaCorrida(int id)
        {
            PistaCorrida pistaCorridaPorId = await GetPistaCorridaById(id);
            if (pistaCorridaPorId == null)
                throw new ArgumentNullException($"User ID:{id} not found");

            _dbContext.PistaCorrida.Remove(pistaCorridaPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}