using Clean_RH.Application.ViewModels;
using Clean_RH.Core.Interfaces.Core;
using Clean_RH.Core.Interfaces.Infra;

namespace Clean_RH.Core.Servicos
{
    public class RetornarCandidatoService: IRetornarCandidatoService
    {
        public readonly IConsultarCandidatosPendente _consultarCandidatosPendente;

        public RetornarCandidatoService(IConsultarCandidatosPendente consultarCandidatosPendente)
        {
            _consultarCandidatosPendente = consultarCandidatosPendente;
        }

        public RetornoCandidatoViewModel RetornarCandidatoPendente()
        {
            var retornoCandidatoPendente = _consultarCandidatosPendente.GetCandidatoPendente();

            return retornoCandidatoPendente;
        }
    }
}
