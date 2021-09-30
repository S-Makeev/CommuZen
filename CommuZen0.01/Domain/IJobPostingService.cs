using CommuZen0._01.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommuZen0._01.Domain
{
    public interface IJobPostingService
    {
        List<JobPostingEntity> GetAll();
        Task<int> Create(JobPostingEntity entity);
    }
}
  