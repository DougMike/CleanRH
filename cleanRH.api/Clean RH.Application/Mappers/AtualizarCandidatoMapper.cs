using Clean_RH.Application.ViewModels;
using Clean_RH.Core.Entidade;
using CursoFormacao = Clean_RH.Core.Entidade.CursoFormacao;

namespace Clean_RH.Application.Mappers
{
    public class AtualizarCandidatoMapper
    {
        public static AtualizarCandidatoEntity ToAtualizarCandidatoEntity(AtualizarCandidatoViewModel atualizarCandidatoViewModel)
        {
            var listaCursoFormacao = new List<CursoFormacao>();

            foreach (var i in atualizarCandidatoViewModel.CursoFormacao)
            {
                CursoFormacao getCursoFormacao = new(
                    i.Curso,
                    i.StatusCursoFormacao
                    );
                listaCursoFormacao.Add(getCursoFormacao);
            }

            var atualizarCandidatoEntity = new AtualizarCandidatoEntity(
                atualizarCandidatoViewModel.IdContratado,
                atualizarCandidatoViewModel.Nome,
                atualizarCandidatoViewModel.CPF,
                listaCursoFormacao
                );

            return atualizarCandidatoEntity;
        }
    }
}
