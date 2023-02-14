using Clean_RH.Application.ViewModels;
using Clean_RH.Core.Entidade;
using CursoFormacao = Clean_RH.Core.Entidade.CursoFormacao;

namespace Clean_RH.Application.Mappers
{
    public class AtualizarCursoFormacaoMapper
    {
        public static AtualizarCursoFormacaoEntity ToAtualizarCursoFormacaoEntity(AtualizarCursoFormacaoViewModel atualizarCursoFormacaoViewModel)
        {
            var listaCursoFormacao = new List<CursoFormacao>();

            foreach (var i in atualizarCursoFormacaoViewModel.CursoFormacao)
            {
                CursoFormacao getCursoFormacao = new(
                    i.IdCursoFormacao,
                    i.DescricaoCursoFormacao,
                    i.IdSituacao
                    );
                listaCursoFormacao.Add(getCursoFormacao);
            }

            var atualizarCursoFormacaoEntity = new AtualizarCursoFormacaoEntity(
                atualizarCursoFormacaoViewModel.IdContratado,
                listaCursoFormacao
                );

            return atualizarCursoFormacaoEntity;
        }
    }
}
