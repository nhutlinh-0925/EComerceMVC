using Microsoft.AspNetCore.Mvc;

namespace EComerceMVC.Controllers
{
    public class HangHoaController : Controller
    {
        public IActionResult Index(int? Loai)
        {
            return View();
        }
    }
}
