using Clean_RH.Application.Mappers;
using Clean_RH.Application.ViewModels;
using Clean_RH.Core.Entidade;
using Clean_RH.Core.Interfaces.Core;
using Microsoft.AspNetCore.Mvc;

namespace Clean_RH.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AtualizarController : ControllerBase
    {
        private readonly IAtualizarCandidatoService _AtualizarCandidatoService;

        public AtualizarController(IAtualizarCandidatoService atualizarCandidatoService)
        {
            _AtualizarCandidatoService = atualizarCandidatoService;
        }

        [HttpPut]
        [Route("AtualizarDadosColaborador")]
        public IActionResult AtualizarCandidato([FromBody] AtualizarCandidatoViewModel atualizarCandidatoViewModel)
        {
            try
            {
                var atualizarCandidato = AtualizarCandidatoMapper.ToAtualizarCandidatoEntity(atualizarCandidatoViewModel);

                var retornoCandidatoAtualizado = _AtualizarCandidatoService.AtualizarCandidato(atualizarCandidato);

                return Ok(retornoCandidatoAtualizado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}