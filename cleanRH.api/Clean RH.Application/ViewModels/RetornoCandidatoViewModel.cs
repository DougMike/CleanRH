using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_RH.Application.ViewModels
{
    public class RetornoCandidatoViewModel
    {
        public RetornoCandidatoViewModel(string nome, string cPF)
        {
            Nome = nome;
            CPF = cPF;
        }

        public string Nome { get; set; }
        public string CPF { get; set; }
    }
}
