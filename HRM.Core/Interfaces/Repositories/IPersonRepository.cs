
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestTask.Core.Models;

namespace TestTask.Core.Interfaces.Repositories
{
    public interface IPersonRepository
    {
        Task<List<PeopleModel>> GetPeople();
        Task<List<PeopleModel>> FilterPeople(int? IdStatus, int? idDep, int? idPost, string lastNamePart);
        Task<List<StatisticPerson>> GetStatisticPeople(int? IdStatus, DateTime startDate, DateTime endDate, bool isEmployed);
    }
}
