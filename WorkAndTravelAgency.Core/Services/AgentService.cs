using Microsoft.EntityFrameworkCore;
using WorkAndTravelAgency.Core.Contracts;
using WorkAndTravelAgency.Infrastructure.Data;
using WorkAndTravelAgency.Infrastructure.Data.Common;

namespace WorkAndTravelAgency.Core.Services
{
    public class AgentService : IAgentService
    {
        private readonly IRepository repo;

        public AgentService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task Create(string userId, string phoneNumber, string firstName, string lastName)
        {
            var agent = new Agent()
            {
                FirstName = firstName,
                LastName = lastName,
                UserId = userId,
                Phone = phoneNumber
            };

            await repo.AddAsync(agent);
            await repo.SaveChangesAsync();

        }

        public async Task<bool> ExistsById(string userId)
        {
            return await repo.All<Agent>()
                .AnyAsync(a => a.UserId == userId);
        }

        public async Task<int> GetAgentId(string userId)
        {
            return (await repo.AllReadonly<Agent>()
                 .FirstOrDefaultAsync(a => a.UserId == userId))?.Id ?? 0;
        }

        public async Task<bool> UserWithPhoneNumberExists(string phoneNumber)
        {
            return await repo.All<Agent>()
               .AnyAsync(a => a.Phone == phoneNumber);
        }
    }
}
