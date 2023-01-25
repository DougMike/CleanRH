using Clean_RH.Core.Interfaces.Infra;
using Microsoft.Extensions.Configuration;

namespace Clean_RH.Infrastructure.Infra
{
    public class ConexaoDB : IConexaoDB
    {
        private readonly IConfiguration _config;

        public ConexaoDB(IConfiguration config)
        {
            _config = config;
        }

        public string GetConexao()
        {
            try
            {
                string _conn = Convert.ToString(_config.GetSection("Data:ConnectionString").Value);

                return _conn;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
