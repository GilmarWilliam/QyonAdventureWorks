using Microsoft.AspNetCore.Mvc;
using QyonAdventureWorks.Domain.Models;
using QyonAdventureWorks.Domain.Repositories;

namespace QyonAdventureWorks.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetidorController : ControllerBase
    {
        private readonly ICompetidorRepository _competidorRepository;

        public CompetidorController
        (
            ICompetidorRepository competidorRepository
        )
        {
            _competidorRepository = competidorRepository;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Competidor>> GetCompetidorById(int id)
        {
            var result = await _competidorRepository.GetCompetidorById(id);
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<List<Competidor>>> GetCompetidor()
        {
            var result = await _competidorRepository.GetCompetidor();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Competidor>> CreateCompetidor([FromBody] Competidor competidor)
        {
            var result = await _competidorRepository.CreateCompetidor(competidor);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<Competidor>> UpdateCompetidor([FromBody] Competidor competidor)
        {
            var result = await _competidorRepository.UpdateCompetidor(competidor);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Competidor>> DeleteCompetidor(int id)
        {
            var result = await _competidorRepository.DeleteCompetidor(id);
            return Ok(result);
        }
    }
}