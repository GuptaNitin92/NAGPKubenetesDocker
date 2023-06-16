using NAGP2023KubernetesDocker.Models;
using System.Data;
using Dapper;
using MySql.Data.MySqlClient;

namespace NAGP2023KubernetesDocker.DB
{
    public class DAL : IDAL
    {
        private readonly ILogger<DAL> _logger;
        private readonly IConfiguration _configuration;
        private readonly string connString;
        public DAL(ILogger<DAL> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            var host = _configuration["DBHOST"] ?? "localhost";

            var port = _configuration["DBPORT"] ?? "3306";

            var password = _configuration["MYSQL_PASSWORD"] ?? _configuration.GetConnectionString("MYSQL_PASSWORD");

            var userid = _configuration["MYSQL_USER"] ?? _configuration.GetConnectionString("MYSQL_USER");

            var usersDataBase = _configuration["MYSQL_DATABASE"] ?? _configuration.GetConnectionString("MYSQL_DATABASE");




            connString = $"server={host}; userid={userid};pwd={password};port={port};database={usersDataBase}";
        }
        public async Task<List<NAGPSessionData>> ExecuteQuery()
        {
            var sessions = new List<NAGPSessionData>();
            string query = @"SELECT * FROM sessiondetails";

            using (var connection = new MySqlConnection(connString))

            {

                var result = await connection.QueryAsync<NAGPSessionData>(query, CommandType.Text);

                sessions = result.ToList();

            }

            return sessions;
        }
    }
}
