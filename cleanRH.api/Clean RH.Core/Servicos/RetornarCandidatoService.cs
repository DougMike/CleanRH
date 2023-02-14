using Clean_RH.Core.Entidade;
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

        public RetornoCandidatoEntity RetornarCandidatoPendente()
        {
            var retornoCandidatoPendente = _consultarCandidatosPendente.GetCandidatoPendente();

            return retornoCandidatoPendente;
        }
    }
}
