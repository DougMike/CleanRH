namespace Clean_RH.Application.ViewModels
{
    public class AtualizarCandidatoViewModel
    {
        public AtualizarCandidatoViewModel(int idContratado, string nome, string cPF)
        {
            IdContratado = idContratado;
            Nome = nome;
            CPF = cPF;
        }

        public int IdContratado { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set;}
    }
}