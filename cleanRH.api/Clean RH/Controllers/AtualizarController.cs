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
        [Route("AtualizarDadosCandidato")]
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

        [HttpPut]
        [Route("AtualizarDadosDependente")]
        public IActionResult AtualizarDependente([FromBody] AtualizarDependenteViewModel atualizarDependenteViewModel)
        {
            try
            {
                var atualizarDependente = AtualizarDependenteMapper.ToAtualizarDependenteEntity(atualizarDependenteViewModel);


            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        [Route("AtualizarDadosCursoFormacao")]
        public IActionResult AtualizarCursoFormacao([FromBody] AtualizarCursoFormacaoViewModel atualizarCursoFormacaoViewModel)
        {
            try
            {
                var atualizarCursoFormacao = AtualizarCursoFormacaoMapper.ToAtualizarCursoFormacaoEntity(atualizarCursoFormacaoViewModel);

                var retornoCursoFormacaoAtualizado = _AtualizarCandidatoService.AtualizarCursoFormacao(atualizarCursoFormacao);

                return Ok(retornoCursoFormacaoAtualizado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        [Route("AtualizarDadosBeneficio")]
        public IActionResult AtualizarBeneficio([FromBody] AtualizarBeneficioViewModel atualizarBeneficioViewModel)
        {
            try
            {
                var atualizarBeneficio = AtualizarBeneficioMapper.ToAtualizarBeneficioEntity(atualizarBeneficioViewModel);

                var retornoBeneficioAtualizado = _AtualizarCandidatoService.AtualizarBeneficio(atualizarBeneficio);

                return Ok(retornoBeneficioAtualizado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}