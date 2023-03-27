using Microsoft.AspNetCore.Mvc;
using P013AspNetMVCEgitim.Models;

namespace P013AspNetMVCEgitim.Controllers
{
    public class MVC08ViewResultsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Yonlendir(string arananDeger)
        {
            //return Redirect("/Home"); // bu action tetiklendiğinde uygulama anasayfaya gitsin
            //return Redirect($"/Home?kelime={arananDeger}"); // burada ? işaretinden sonraki kısım querystring yöntemiyle adres çubuğu üzerinden veri yollamak için
            return Redirect("https://getbootstrap.com/");
        }
        public IActionResult ActionaYonlendir()
        {
            //return RedirectToAction("Index"); // metot çalıştığında aynı controllerdaki bir actiona yönlendirmemizi sağlar
            return RedirectToAction("Index", "Home"); // metot çalıştığında farklı bir controller daki actiona bu şekilde yönlendirebiliriz
        }
        public RedirectToRouteResult RouteYonlendir() // IActionResult da yapsaydık olurdu
        {
            return RedirectToRoute("Default", new { controller="Home", action="Index", id = 18 }); // metot çalıştığında route sistemiyle yönlendirme yapmamızı sağlar
        }
        public PartialViewResult KategorileriGetirPartial() // IActionResult da yapsaydık olurdu
        {
            return PartialView("_KategorilerPartial");
        }
        public IActionResult XmlContentResult()
        {
            var xml = @"
                    <Kullanicilar>
                     <Kullanici>
                        <Adi>
                            Murat 
                        </Adi>
                        <Soyadi>
                            Yılmaz 
                        </Soyadi>
                     </Kullanici>
                     <Kullanici>
                        <Adi>
                            Alp 
                        </Adi>
                        <Soyadi>
                            Arslan 
                        </Soyadi>
                     </Kullanici>
                    </Kullanicilar>
                ";
            return Content(xml, "application/xml"); // geriye xml içeriğini döndürdük
        }
        public IActionResult JsonDondur()
        {
            var kullanici = new Kullanici()
            {
                 Ad = "Alp", Soyad = "Çakmak", KullaniciAdi = "alpi"
            };
            return Json(kullanici);
        }
    }
}
