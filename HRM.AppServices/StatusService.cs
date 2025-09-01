
using System.Collections.Generic;
using System.Threading.Tasks;
using TestTask.Core.Interfaces.Repositories;
using TestTask.Core.Interfaces.Services;
using TestTask.Core.Models;

namespace TestTask.Services
{
    public class StatusService : IStatusService
    {
        private readonly IStatusRepository _statusRepository;

        public StatusService(IStatusRepository statusRepository)
        {
            _statusRepository = statusRepository;
        }

        public async Task<List<StatusModel>> GetStatuses()
        {
            return await _statusRepository.GetStatuses();
        }
    }
}
