using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Agent;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Controllers
{
    public class AgentController : BaseController
    {
        private readonly IAgentService agentService;

        public AgentController(IAgentService _agentService)
        {
            agentService = _agentService;
        }

        [HttpPost]
        public async Task<IActionResult> Become()
        {
            var model = new BecomeAgentFromModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Become(BecomeAgentFromModel model)
        {
            return RedirectToAction(nameof(HouseController.All), "House");
        }
    }
}
