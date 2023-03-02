using Microsoft.AspNetCore.Mvc;
using QyonAdventureWorks.Domain.Models;
using QyonAdventureWorks.Domain.Repositories;

namespace QyonAdventureWorks.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoricoCorridaController : ControllerBase
    {
        private readonly IHistoricoCorridaRepository _historicoCorridaRepository;

        public HistoricoCorridaController
        (
            IHistoricoCorridaRepository historicoCorridaRepository
        )
        {
            _historicoCorridaRepository = historicoCorridaRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<HistoricoCorrida>>> GetHistoricoCorrida()
        {
            var result = await _historicoCorridaRepository.GetHistoricoCorrida();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<HistoricoCorrida>> CreateHistoricoCorrida([FromBody] HistoricoCorrida historicoCorrida)
        {
            var result = await _historicoCorridaRepository.CreateHistoricoCorrida(historicoCorrida);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<HistoricoCorrida>> UpdateHistoricoCorrida([FromBody] HistoricoCorrida historicoCorrida)
        {
            var result = await _historicoCorridaRepository.UpdateHistoricoCorrida(historicoCorrida);
            return Ok(result);
        }
    }
}