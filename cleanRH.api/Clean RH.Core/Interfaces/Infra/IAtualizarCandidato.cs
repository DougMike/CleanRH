using Clean_RH.Core.Entidade;

namespace Clean_RH.Core.Interfaces.Infra
{
    public interface IAtualizarCandidato
    {
        void AtualizaCandidato(AtualizarCandidatoEntity atualizarCandidatoEntity);
        void AtualizaDependente(AtualizarDependenteEntity atualizarDependenteEntity);
        void AtualizaCursoFormacao(AtualizarCursoFormacaoEntity atualizarCursoFormacaoEntity);
        void AtualizaBeneficio(AtualizarBeneficioEntity atualizarBeneficioEntity);
    }
}