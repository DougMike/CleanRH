using Clean_RH.Application.ViewModels;
using Clean_RH.Core.Entidade;
using Beneficio = Clean_RH.Core.Entidade.Beneficio;
using Dependente = Clean_RH.Core.Entidade.Dependente;

namespace Clean_RH.Application.Mappers
{
    public class AtualizarBeneficioMapper
    {
        public static AtualizarBeneficioEntity ToAtualizarBeneficioEntity(AtualizarBeneficioViewModel atualizarBeneficioViewModel)
        {
            var listaBeneficio = new List<Beneficio>();

            foreach (var i in atualizarBeneficioViewModel.Beneficio)
            {
                Beneficio getBeneficio = new(
                    i.IdConBeneficio,
                    i.IdTipoBeneficio,
                    i.DtdInicio
                    );
                listaBeneficio.Add(getBeneficio);
            }

            var atualizarBeneficioEntity = new AtualizarBeneficioEntity(
                atualizarBeneficioViewModel.IdContratado,
                listaBeneficio
                );

            return atualizarBeneficioEntity;
        }
    }
}
