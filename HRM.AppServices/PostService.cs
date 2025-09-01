
using System.Collections.Generic;
using System.Threading.Tasks;
using TestTask.Core.Interfaces.Repositories;
using TestTask.Core.Interfaces.Services;
using TestTask.Core.Models;

namespace TestTask.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<List<PostModel>> GetPosts()
        {
            return await _postRepository.GetPosts();
        }
    }
}
