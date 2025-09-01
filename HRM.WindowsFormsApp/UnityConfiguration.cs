
using System.Data.SqlClient;
using System.Threading.Tasks;
using TestTask.Core.Interfaces.Repositories;
using TestTask.Core.Interfaces.Services;
using TestTask.Persistence;
using TestTask.Services;
using Unity;

namespace TestTask.WindowsFormsApp
{
    internal static class UnityConfiguration
    {
        public static async Task RegistrationDb(this UnityContainer unityContainer, string dataSource, string initialCatalog, string userId, string password)
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = dataSource,
                InitialCatalog = initialCatalog,
                UserID = userId,
                Password = password,
            };

            using (var connection = new SqlConnection(builder.ConnectionString))
            {
                await connection.OpenAsync();
            }
            unityContainer.RegisterInstance(builder.ConnectionString);
        }

        public static void RegistrationServices(this UnityContainer unityContainer)
        {
            unityContainer.RegisterType<IPersonService, PersonService>();
            unityContainer.RegisterType<IPostService, PostService>();
            unityContainer.RegisterType<IStatusService, StatusService>();
            unityContainer.RegisterType<IDepService, DepService>();
        }

        public static void RegistrationRepositories(this UnityContainer unityContainer)
        {
            unityContainer.RegisterType<IPersonRepository, PersonRepository>();
            unityContainer.RegisterType<IPostRepository, PostRepository>();
            unityContainer.RegisterType<IStatusRepository, StatusRepository>();
            unityContainer.RegisterType<IDepRepository, DepRepository>();
        }
    }
}
