using Microsoft.AspNetCore.Mvc;

namespace OnlineUsedCarsShowroom.Controllers
{
    public class SaleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
