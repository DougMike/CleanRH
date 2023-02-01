using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_RH.Core.Entidade
{
    public class RetornoCandidatoAtualizaEntity
    {
        public RetornoCandidatoAtualizaEntity(string candidato)
        {
            Candidato = candidato;
        }

        public string Candidato { get; set; }
    }
}
