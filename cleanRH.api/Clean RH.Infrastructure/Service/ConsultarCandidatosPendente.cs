using Clean_RH.Application.ViewModels;
using Clean_RH.Core.Interfaces.Infra;
using Dapper;
using MySqlConnector;

namespace Clean_RH.Infrastructure.Service
{
    public class ConsultarCandidatosPendente : IConsultarCandidatosPendente
    {
        private readonly IConexaoDB _conexaoDB;
        private readonly string _stringConexao;


        public ConsultarCandidatosPendente(IConexaoDB conexaoDB)
        {

            _conexaoDB = conexaoDB;

            _stringConexao = _conexaoDB.GetConexao();
        }

        public RetornoCandidatoViewModel GetCandidatoPendente()
        {
            try
            {
                using var _conn = new MySqlConnection(_stringConexao);

                var sql = @"
                SELECT                    
                    con_dssnome,
                    con_coscic
                FROM
                CONTRATADOS
                LIMIT 10
            ";
                var select = _conn.Query<Candidato>(sql);

                var listCandidatos = new List<Candidato>();

                foreach (var i in select)
                {
                    Candidato getCandidatoAtivo = new
                    (
                        i.Nome,
                        i.CPF
                    );
                    listCandidatos.Add(getCandidatoAtivo);
                }

                var retornoCandidato = new RetornoCandidatoViewModel(listCandidatos);

                return retornoCandidato;

            }
            catch (Exception)
            {
                throw;
            }            
        }
    }
}
