
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using TestTask.Core.Interfaces.Repositories;
using TestTask.Core.Models;

namespace TestTask.Persistence
{
    public class PostRepository : IPostRepository
    {
        private readonly string _sqlConnectionString;

        public PostRepository(string sqlConnectionString)
        {
            _sqlConnectionString = sqlConnectionString;
        }
        
        public async Task<List<PostModel>> GetPosts()
        {
            var posts = new List<PostModel>();

            using (var connection = new SqlConnection(_sqlConnectionString))
            using (SqlCommand cmd = new SqlCommand("usp_GetPosts", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                if (connection.State != ConnectionState.Open)
                    await connection.OpenAsync();

                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        posts.Add(new PostModel
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                        });
                    }
                }
            }

            return posts;
        }
    }
}
