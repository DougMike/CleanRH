namespace Clean_RH.Core.Entidade
{
    public class AtualizarDependenteEntity
    {
        public AtualizarDependenteEntity(int idContratado, List<Dependente> dependente)
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