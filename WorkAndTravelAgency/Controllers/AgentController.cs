using HouseRentingSystem.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorkAndTravelAgency.Core.Contracts;
using WorkAndTravelAgency.Core.Models.Agent;

namespace WorkAndTravelAgency.Controllers
{
    [Authorize]
    public class AgentController : Controller
    {
        private readonly IAgentService agentService;

        public AgentController(IAgentService _agentService)
        {
            agentService = _agentService;
        }
        [HttpGet]

        public async Task<IActionResult> Become()
        {
            if (await agentService.ExistsById(User.Id()))
            {
    
                return RedirectToAction("Index", "Home");
            }
            var model = new BecomeAgentModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Become(BecomeAgentModel model)
        {
            var userId = User.Id();

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (await agentService.ExistsById(userId))
            {

                return RedirectToAction("Index", "Home");
            }

            if (await agentService.UserWithPhoneNumberExists(model.PhoneNumber))
            {

                return RedirectToAction("Index", "Home");
            }

            await agentService.Create(userId, model.PhoneNumber, model.FirstName, model.LastName);

            return RedirectToAction("All", "House");
        }
    }
}
