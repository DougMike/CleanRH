using Clean_RH.Application.ViewModels;
using Clean_RH.Core.Entidade;
using Clean_RH.Core.Interfaces.Infra;
using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_RH.Infrastructure.Service
{
    public class AtualizarCandidato : IAtualizarCandidato
    {
        private readonly IConexaoDB _conexaoDB;
        private readonly string _stringConexao;


        public AtualizarCandidato(IConexaoDB conexaoDB)
        {

            _conexaoDB = conexaoDB;

            _stringConexao = _conexaoDB.GetConexao();
        }

        public void AtualizaCandidato(AtualizarCandidatoEntity atualizarCandidatoEntity)
        {
            try
            {
                using var _conn = new MySqlConnection(_stringConexao);

                var sql = @"
                UPDATE 
                    CONTRATADOS 
                SET                    
                    CON_DSSNOME = @nome,
                    CON_COSCIC = @cPF
                WHERE
                    CON_CDICONTRATADO = @idContratado
            ";

                var executeSQL = _conn.Execute(sql, new {   atualizarCandidatoEntity.Nome, 
                                                            atualizarCandidatoEntity.CPF,
                                                            atualizarCandidatoEntity.IdContratado
                                                        }
                                                );              
            }
            catch (Exception)
            {
                throw;
            }
        }
        
    }
}
