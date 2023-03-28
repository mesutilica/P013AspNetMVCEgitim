using Microsoft.AspNetCore.Mvc;
using P013AspNetMVCEgitim.Filters;

namespace P013AspNetMVCEgitim.Controllers
{
    public class MVC14FiltersUsingController : Controller
    {
        [UserControl] // kendi yazdığımız UserControl attribute ü ile bu action a oturum açmayan kullanıcıların erişimini engelliyoruz
        public IActionResult Index()
        {
            ViewBag.Kullanici = HttpContext.Session.GetString("UserGuid"); // UserGuid isimli session daki değeri yakala ve ViewBag.Kullanici ile ekrana gönder
            return View();
        }
    }
}
