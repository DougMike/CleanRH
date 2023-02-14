using Clean_RH.Core.Interfaces.Core;
using Microsoft.AspNetCore.Mvc;

namespace Clean_RH.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConsultarController : ControllerBase
    {
        public readonly IRetornarCandidatoService _retornarCandidatoService;

        public ConsultarController(IRetornarCandidatoService retornarCandidatoService)
        {            
            _retornarCandidatoService = retornarCandidatoService;
        }

        [HttpGet]
        [Route("DadosColaborador")]
        public IActionResult ConsultarCandidato()
        {
            try
            {
                var retornoCandidato = _retornarCandidatoService.RetornarCandidatoPendente();

                return Ok(retornoCandidato);

            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
    }
}