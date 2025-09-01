
using System.Collections.Generic;
using System.Threading.Tasks;
using TestTask.Core.Models;

namespace TestTask.Core.Interfaces.Services
{
    public interface IPostService
    {
        Task<List<PostModel>> GetPosts();
    }
}
