using Clean_RH.Application.ViewModels;
using Clean_RH.Core.Entidade;

namespace Clean_RH.Application.Mappers
{
    public class AtualizarCandidatoMapper
    {
        public static AtualizarCandidatoEntity ToAtualizarCandidatoEntity(AtualizarCandidatoViewModel atualizarCandidatoViewModel)
        {
            var atualizarCandidatoEntity = new AtualizarCandidatoEntity(
                atualizarCandidatoViewModel.IdContratado,
                atualizarCandidatoViewModel.Nome,
                atualizarCandidatoViewModel.CPF
                );

            return atualizarCandidatoEntity;
        }
    }
}
