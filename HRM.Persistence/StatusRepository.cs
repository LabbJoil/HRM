
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using TestTask.Core.Interfaces.Repositories;
using TestTask.Core.Models;

namespace TestTask.Persistence
{
    public class StatusRepository : IStatusRepository
    {
        private readonly string _sqlConnectionString;

        public StatusRepository(string sqlConnectionString)
        {
            _sqlConnectionString = sqlConnectionString;
        }

        public async Task<List<StatusModel>> GetStatuses()
        {
            var statuses = new List<StatusModel>();

            using (var connection = new SqlConnection(_sqlConnectionString))
            using (SqlCommand cmd = new SqlCommand("usp_GetStatuses", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                if (connection.State != ConnectionState.Open)
                    await connection.OpenAsync();

                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        statuses.Add(new StatusModel
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                        });
                    }
                }
            }

            return statuses;
        }
    }
}
