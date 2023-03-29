using Microsoft.AspNetCore.Mvc;

namespace P013AspNetMVCEgitim.Areas.Admin.Controllers
{
    [Area("Admin")] // bu controller ın admin areasında çalışmasını sağladık.
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
