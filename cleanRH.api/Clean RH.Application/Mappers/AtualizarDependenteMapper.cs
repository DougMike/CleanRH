using Clean_RH.Application.ViewModels;
using Clean_RH.Core.Entidade;
using Dependente = Clean_RH.Core.Entidade.Dependente;

namespace Clean_RH.Application.Mappers
{
    public class AtualizarDependenteMapper
    {
        public static AtualizarDependenteEntity ToAtualizarDependenteEntity(AtualizarDependenteViewModel atualizarDependenteViewModel)
        {
            var listaDependente = new List<Dependente>();

            foreach (var i in atualizarDependenteViewModel.Dependente)
            {
                Dependente getDependente = new(
                    i.IdDependente,
                    i.Nome,
                    i.CPF
                    );
                listaDependente.Add(getDependente);
            }

            var atualizarDependenteEntity = new AtualizarDependenteEntity(
                atualizarDependenteViewModel.IdContratado,                
                listaDependente
                );

            return atualizarDependenteEntity;
        }
    }
}
