using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAndTravelAgency.Core.Contracts
{
    public interface IAgent
    {
        Task<bool> ExistsById(string userId);

        Task<bool> UserWithPhoneNumberExists(string phoneNumber);

        Task Create(string userId, string phoneNumber, string firstName, string lastName, string imageUrl);

        Task<int> GetAgentId(string userId);
    }
}
