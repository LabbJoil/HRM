
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestTask.Core.Interfaces.Repositories;
using TestTask.Core.Interfaces.Services;
using TestTask.Core.Models;

namespace TestTask.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<List<PeopleModel>> GetPeople()
        {
            return await _personRepository.GetPeople();
        }

        public async Task<List<PeopleModel>> FilterPeople(int? IdStatus, int? idDep, int? idPost, string lastNamePart)
        {
            return await _personRepository.FilterPeople(IdStatus, idDep, idPost, lastNamePart);
        }

        public async Task<List<StatisticPerson>> GetStatisticPeople(int? IdStatus, DateTime startDate, DateTime endDate, bool isEmployed)
        {
            return await _personRepository.GetStatisticPeople(IdStatus, startDate, endDate, isEmployed);
        }
    }
}
