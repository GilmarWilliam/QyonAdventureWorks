using Microsoft.AspNetCore.Mvc;
using QyonAdventureWorks.Domain.Models;
using QyonAdventureWorks.Domain.Repositories;

namespace QyonAdventureWorks.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PistaCorridaController : ControllerBase
    {
        private readonly IPistaCorridaRepository _pistaCorridaRepository;

        public PistaCorridaController
        (
            IPistaCorridaRepository pistaCorridaRepository
        )
        {
            _pistaCorridaRepository = pistaCorridaRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<PistaCorrida>>> GetPistaCorrida()
        {
            var result = await _pistaCorridaRepository.GetPistaCorrida();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<PistaCorrida>> CreatePistaCorrida([FromBody] PistaCorrida pistaCorrida)
        {
            var result = await _pistaCorridaRepository.CreatePistaCorrida(pistaCorrida);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<PistaCorrida>> UpdatePistaCorrida([FromBody] PistaCorrida pistaCorrida)
        {
            var result = await _pistaCorridaRepository.UpdatePistaCorrida(pistaCorrida);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PistaCorrida>> DeletePistaCorrida(int id)
        {
            var result = await _pistaCorridaRepository.DeletePistaCorrida(id);
            return Ok(result);
        }
    }
}