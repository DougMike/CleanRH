using Microsoft.AspNetCore.Mvc;

namespace Clean_RH.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConsultarController : ControllerBase
    {
        

        private readonly ILogger<ConsultarController> _logger;

        public ConsultarController(ILogger<ConsultarController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("DadosColaborador")]
        public IActionResult ConsultarColaborador()
        {
            try
            {
                return Ok("[{Nome: Willian, CPF: 123.123.123-41}]");

            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
    }
}