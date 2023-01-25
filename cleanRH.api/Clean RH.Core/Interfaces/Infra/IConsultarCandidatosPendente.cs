using Clean_RH.Application.ViewModels;

namespace Clean_RH.Core.Interfaces.Infra
{
    public interface IConsultarCandidatosPendente
    {
        RetornoCandidatoViewModel GetCandidatoPendente();
    }
}