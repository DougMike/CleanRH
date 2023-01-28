using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_RH.Application.ViewModels
{
    public class RetornoCandidatoViewModel
    {
        public RetornoCandidatoViewModel(List<Candidato> candidato)
        {
            Candidato = candidato;
        }

        public List<Candidato> Candidato { get; set; }
    }        

    public class Candidato
    {
        public Candidato(string con_dssnome, string con_coscic)
        {
            Nome = con_dssnome;
            CPF = con_coscic;
        }
        public string Nome { get; set; }
        public string CPF { get; set; }
    }
}

