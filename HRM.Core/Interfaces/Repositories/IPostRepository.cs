
using System.Collections.Generic;
using System.Threading.Tasks;
using TestTask.Core.Models;

namespace TestTask.Core.Interfaces.Repositories
{
    public interface IPostRepository
    {
        Task<List<PostModel>> GetPosts();
    }
}
