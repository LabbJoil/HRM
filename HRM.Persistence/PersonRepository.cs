
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Threading.Tasks;
using TestTask.Core.Interfaces.Repositories;
using TestTask.Core.Models;

namespace TestTask.Persistence
{
    public class PersonRepository : IPersonRepository
    {
        private readonly string _sqlConnectionString;

        public PersonRepository(string sqlConnectionString)
        {
            _sqlConnectionString = sqlConnectionString;
        }

        public async Task<List<PeopleModel>> GetPeople()
        {
            var people = new List<PeopleModel>();

            using (var connection = new SqlConnection(_sqlConnectionString))
            using (SqlCommand cmd = new SqlCommand("usp_GetPeople", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                
                if (connection.State != ConnectionState.Open)
                    await connection.OpenAsync();

                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        people.Add(new PeopleModel
                        {
                            FIO = reader.GetString(0),
                            DateEmploy = reader.IsDBNull(1) ? (DateTime?)null : reader.GetDateTime(1),
                            DateUneploy = reader.IsDBNull(2) ? (DateTime?)null : reader.GetDateTime(2),
                            Status = reader.GetString(3),
                            Dep = reader.GetString(4),
                            Post = reader.GetString(5),
                        });
                    }
                }
            }

            return people;
        }

        public async Task<List<PeopleModel>> FilterPeople(int? idStatus, int? idDep, int? idPost, string lastNamePart)
        {
            var people = new List<PeopleModel>();

            using (var connection = new SqlConnection(_sqlConnectionString))
            using (SqlCommand cmd = new SqlCommand("usp_FilterPeople", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdStatus", (object)idStatus ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@IdDep", (object)idDep ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@IdPost", (object)idPost ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@LastNamePart", (object)lastNamePart ?? DBNull.Value);

                if (connection.State != ConnectionState.Open)
                    await connection.OpenAsync();

                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        people.Add(new PeopleModel
                        {
                            FIO = reader.GetString(0),
                            DateEmploy = reader.IsDBNull(1) ? (DateTime?)null : reader.GetDateTime(1),
                            DateUneploy = reader.IsDBNull(2) ? (DateTime?)null : reader.GetDateTime(2),
                            Status = reader.GetString(3),
                            Dep = reader.GetString(4),
                            Post = reader.GetString(5),
                        });
                    }
                }
            }

            return people;
        }

        public async Task<List<StatisticPerson>> GetStatisticPeople(int? IdStatus, DateTime startDate, DateTime endDate, bool isEmployed)
        {
            var statisticPerson = new List<StatisticPerson>();

            using (var connection = new SqlConnection(_sqlConnectionString))
            using (var cmd = new SqlCommand("usp_GetStatisticPeople", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StatusId", (object)IdStatus ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                cmd.Parameters.AddWithValue("@IsEmployed", isEmployed ? 1 : 0);

                if (connection.State != ConnectionState.Open)
                    await connection.OpenAsync();

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        statisticPerson.Add(new StatisticPerson
                        {
                            Date = reader.GetDateTime(0),
                            Count = reader.GetInt32(1)
                        });
                    }
                }
            }
            return statisticPerson;
        }
    }
}
