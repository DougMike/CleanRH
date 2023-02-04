using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_RH.Application.ViewModels
{
    public class AtualizarDependenteViewModel
    {
        public AtualizarDependenteViewModel(int idContratado, List<Dependente> dependente)
        {
            IdContratado = idContratado;
            Dependente = dependente;
        }

        public int IdContratado { get; set; }
        public List<Dependente> Dependente { get; set; }
    }
    public class Dependente
    {
        public Dependente(int idDependente, string nome, string cPF)
        {
            IdDependente = idDependente;
            Nome = nome;
            CPF = cPF;
        }

        public int IdDependente { get; set; }

        public string Nome { get; set; }
        public string CPF { get; set; }
    }
}