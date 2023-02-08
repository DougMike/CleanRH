using Clean_RH.Core.Entidade;

namespace Clean_RH.Core.Interfaces.Core
{
    public interface IAtualizarCandidatoService
    {
        RetornoCandidatoAtualizadoEntity AtualizarCandidato(AtualizarCandidatoEntity atualizarCandidatoEntity);
        RetornoCandidatoAtualizadoEntity AtualizarDependente(AtualizarDependenteEntity atualizarDependenteEntity);
        RetornoCandidatoAtualizadoEntity AtualizarCursoFormacao(AtualizarCursoFormacaoEntity atualizarCursoFormacaoEntity);
    }
}