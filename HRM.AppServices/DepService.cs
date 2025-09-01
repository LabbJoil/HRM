
using System.Collections.Generic;
using System.Threading.Tasks;
using TestTask.Core.Interfaces.Repositories;
using TestTask.Core.Interfaces.Services;
using TestTask.Core.Models;

namespace TestTask.Services
{
    public class DepService : IDepService
    {
        private readonly IDepRepository _depRepository;

        public DepService(IDepRepository depRepository)
        {
            _depRepository = depRepository;
        }

        public async Task<List<DepModel>> GetDeps()
        {
            return await _depRepository.GetDeps();
        }
    }
}
