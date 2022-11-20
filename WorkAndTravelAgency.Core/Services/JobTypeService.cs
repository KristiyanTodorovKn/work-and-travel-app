using Microsoft.EntityFrameworkCore;
using WorkAndTravelAgency.Core.Contracts;
using WorkAndTravelAgency.Core.Models.JobType;
using WorkAndTravelAgency.Infrastructure.Data;
using WorkAndTravelAgency.Infrastructure.Data.Common;

namespace WorkAndTravelAgency.Core.Services
{
    public class JobTypeService : IJobType
    {
        private readonly IRepository repo;

        public JobTypeService(IRepository _repo)
        {
            repo = _repo;
        }
        public async Task<int> Create(JobTypeModel model, int agentId)
        {
            var jobType = new JobType()
            {
                Salary = model.Salary,
                AgentId = model.AgentId,
                Name = model.Name
            };

            await repo.AddAsync(jobType);
            await repo.SaveChangesAsync();

            return jobType.Id;
        }

        public async Task<bool> JobExists(int jobTypeId)
        {
            return await repo.AllReadonly<JobType>()
               .AnyAsync(jt => jt.Id == jobTypeId);
        }

        public async Task<IEnumerable<JobTypeModel>> LastThreeJobs()
        {
            return await repo.AllReadonly<JobType>()
                .OrderByDescending(j => j.Id)
                .Select(j => new JobTypeHomeModel()
                {
                    Id = j.Id,
                    Name = j.Name,
                    Salary = j.Salary
                })
                .Take(3)
                .ToListAsync();

        }
    }
}
