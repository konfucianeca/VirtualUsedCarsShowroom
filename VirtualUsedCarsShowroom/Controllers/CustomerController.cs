using CarsShowroom.Core.Models.Appointment;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OnlineUsedCarsShowroom.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> AddCustomer()
        {
            var model = new AppointmentFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer(AppointmentFormModel model)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
