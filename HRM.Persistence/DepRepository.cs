
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using TestTask.Core.Interfaces.Repositories;
using TestTask.Core.Models;

namespace TestTask.Persistence
{
    public class DepRepository : IDepRepository
    {
        private readonly string _sqlConnectionString;

        public DepRepository(string sqlConnectionString)
        {
            _sqlConnectionString = sqlConnectionString;
        }

        public async Task<List<DepModel>> GetDeps()
        {
            var deps = new List<DepModel>();

            using (var connection = new SqlConnection(_sqlConnectionString))
            using (SqlCommand cmd = new SqlCommand("usp_GetDeps", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                if (connection.State != ConnectionState.Open)
                    await connection.OpenAsync();

                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        deps.Add(new DepModel
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                        });
                    }
                }
            }

            return deps;
        }
    }
}
