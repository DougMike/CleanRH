namespace Clean_RH.Core.Entidade
{
    public class AtualizarCursoFormacaoEntity
    {
        public AtualizarCursoFormacaoEntity(int idContratado, List<CursoFormacao> cursoFormacao)
        {
            IdContratado = idContratado;
            CursoFormacao = cursoFormacao;
        }

        public int IdContratado { get; set; } 
        public List<CursoFormacao> CursoFormacao { get; set; }
    }

    public class CursoFormacao
    {
        public CursoFormacao(int idCursoFormacao, string descricaoCursoFormacao, int idSituacao)
        {
            IdCursoFormacao = idCursoFormacao;
            DescricaoCursoFormacao = descricaoCursoFormacao;
            IdSituacao = idSituacao;
        }

        public int IdCursoFormacao { get; set; }
        public string DescricaoCursoFormacao { get; set;}
        public int IdSituacao { get; set; }
    }
}