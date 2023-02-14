using Clean_RH.Core.Entidade;

namespace Clean_RH.Core.Interfaces.Infra
{
    public interface IConsultarCandidatosPendente
    {
        RetornoCandidatoEntity GetCandidatoPendente();
    }
}