using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAndTravelAgency.Core.Contracts
{
    public interface IAgentService
    {
        Task<bool> ExistsById(string userId);

        Task<bool> UserWithPhoneNumberExists(string phoneNumber);

        Task Create(string userId, string phoneNumber, string firstName, string lastName);

        Task<int> GetAgentId(string userId);
    }
}
