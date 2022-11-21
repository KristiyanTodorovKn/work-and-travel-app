using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkAndTravelAgency.Core.Models.JobType;

namespace WorkAndTravelAgency.Core.Contracts
{
    public interface IJobTypeService
    {
        public Task<bool> JobExists(int jobTypeId);

        public Task<int> Create(JobTypeModel model, int agentId);

        Task<IEnumerable<JobTypeHomeModel>> LastThreeJobs();
    }
}
