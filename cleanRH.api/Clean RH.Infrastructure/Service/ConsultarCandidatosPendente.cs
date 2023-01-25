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
            using var _conn = new MySqlConnection(_stringConexao);

            var sql = @"
                SELECT                    
                    con_dssnome,
                    con_coscic
                FROM
                CONTRATADOS
                LIMIT 1
            ";
            var select = _conn.Query(sql); 

            var retornoCandidato = new RetornoCandidatoViewModel("Will", "123");          

            return retornoCandidato;
        }
    }
}
