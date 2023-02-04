using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clean_RH.Core.Entidade;
using Clean_RH.Core.Interfaces.Core;
using Clean_RH.Core.Interfaces.Infra;

namespace Clean_RH.Core.Servicos
{
    public class AtualizarCandidatoService : IAtualizarCandidatoService
    {
        private readonly IAtualizarCandidato _AtualizarCandidato;

        public AtualizarCandidatoService(IAtualizarCandidato atualizarCandidato)
        {
            _AtualizarCandidato = atualizarCandidato;
        }

        public RetornoCandidatoAtualizadoEntity AtualizarCandidato(AtualizarCandidatoEntity atualizarCandidatoEntity)
        {
            try
            {
                _AtualizarCandidato.AtualizaCandidato(atualizarCandidatoEntity);

                var retornoCandidato = new RetornoCandidatoAtualizadoEntity(atualizarCandidatoEntity.Nome);

                return retornoCandidato;

            }
            catch (Exception)
            {
                throw;
            }            
        }

        public RetornoCandidatoAtualizadoEntity AtualizarDependente(AtualizarDependenteEntity atualizarDependenteEntity)
        {
            try
            {
                _AtualizarCandidato.AtualizaDependente(atualizarDependenteEntity);

                var retornoCandidato = new RetornoCandidatoAtualizadoEntity("teste");

                return retornoCandidato;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
