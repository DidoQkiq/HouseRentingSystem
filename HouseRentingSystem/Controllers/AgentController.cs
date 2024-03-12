using HouseRentingSystem.Core.Models.Agent;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Controllers
{
    [Authorize]
    public class AgentController : Controller
    {
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
