using Clean_RH.Core.Entidade;

namespace Clean_RH.Core.Interfaces.Core
{
    public interface IAtualizarCandidatoService
    {
        RetornoCandidatoAtualizaEntity AtualizarCandidato(AtualizarCandidatoEntity atualizarCandidatoEntity);
    }
}