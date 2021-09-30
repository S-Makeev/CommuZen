using CommuZen0._01.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommuZen0._01.Domain
{
    public class JobPostingService : IJobPostingService
    {
        public async Task<int> Create(JobPostingEntity entity)
        {
            return 1;
        }

        public List<JobPostingEntity> GetAll()
        {
            var collection = new List<JobPostingEntity>();
            collection.Add(new JobPostingEntity { Body = "Service", Header = "Jobs", Id = 1 });
            return collection;
        }
    }
}
