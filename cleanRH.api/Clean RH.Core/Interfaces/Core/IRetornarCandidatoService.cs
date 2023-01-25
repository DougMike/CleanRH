using Clean_RH.Application.ViewModels;

namespace Clean_RH.Core.Interfaces.Core
{
    public interface IRetornarCandidatoService
    {
        RetornoCandidatoViewModel RetornarCandidatoPendente();
    }
}