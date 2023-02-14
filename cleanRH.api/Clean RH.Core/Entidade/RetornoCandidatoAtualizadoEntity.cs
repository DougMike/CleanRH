namespace Clean_RH.Core.Entidade
{
    public class RetornoCandidatoAtualizadoEntity
    {
        public RetornoCandidatoAtualizadoEntity(string candidato)
        {
            Candidato = candidato;
        }

        public string Candidato { get; set; }
    }
}
