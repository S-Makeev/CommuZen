using CommuZen0._01.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommuZen0._01.Domain
{
    public class JobPostingService : IJobPostingService
    {
        public async Task<int> Create(VacancyEntity entity)
        {
            return 1;
        }

        public List<VacancyEntity> GetAll()
        {
            var collection = new List<VacancyEntity>();
            collection.Add(new VacancyEntity { Body = "Service", Header = "Jobs", Id = 1 });
            return collection;
        }
    }
}
