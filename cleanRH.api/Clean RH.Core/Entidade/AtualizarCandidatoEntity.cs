namespace Clean_RH.Core.Entidade
{
    public class AtualizarCandidatoEntity
    {
        public AtualizarCandidatoEntity(int idContratado, string nome, string cPF, List<CursoFormacao> cursoFormacao)
        {
            IdContratado = idContratado;
            Nome = nome;
            CPF = cPF;
            CursoFormacao = cursoFormacao;
        }

        public int IdContratado { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set;}
        public List<CursoFormacao> CursoFormacao { get; set; }
    }
    public class CursoFormacao
    {
        public CursoFormacao(string curso, string statusCursoFormacao)
        {
            Curso = curso;
            StatusCursoFormacao = statusCursoFormacao;
        }

        public string Curso { get; set;}
        public string StatusCursoFormacao { get; set;}
    }
}