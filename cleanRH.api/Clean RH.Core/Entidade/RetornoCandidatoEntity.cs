namespace Clean_RH.Core.Entidade
{
    public class RetornoCandidatoEntity
    {
        public RetornoCandidatoEntity(List<Candidato> candidato)
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
