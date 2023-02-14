namespace Clean_RH.Core.Entidade
{
    public class AtualizarCandidatoEntity
    {
        public AtualizarCandidatoEntity(int idContratado, string nome, string cPF)
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