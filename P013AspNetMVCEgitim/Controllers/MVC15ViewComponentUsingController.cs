using Microsoft.AspNetCore.Mvc;

namespace P013AspNetMVCEgitim.Controllers
{
    public class MVC15ViewComponentUsingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
