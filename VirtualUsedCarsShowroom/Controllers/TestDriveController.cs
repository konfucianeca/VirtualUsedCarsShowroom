using Microsoft.AspNetCore.Mvc;

namespace OnlineUsedCarsShowroom.Controllers
{
    public class TestDriveController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
