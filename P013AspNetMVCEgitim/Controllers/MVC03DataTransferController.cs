using Microsoft.AspNetCore.Mvc;

namespace P013AspNetMVCEgitim.Controllers
{
    public class MVC03DataTransferController : Controller
    {
        public IActionResult Index(string Ara) // get metoduyla gönderilen verileri bu şekilde string Ara yazarak yakalayabiliriz
        {
            // Mvc de temel olarak 3 farklı yöntemle ekrana veri gönderebiliriz

            // 1-ViewBag : Tek kullanımlık ömrü var
            ViewBag.UrunKategorisi = "Bilgisayar";
            // 2-ViewData : Tek kullanımlık ömrü var
            ViewData["UrunAdi"] = "Asus Dizüstü Bilgisayar";
            // 3-TempData : İki kullanımlık ömrü var
            TempData["UrunFiyati"] = 9999;

            ViewBag.GetVerisi = Ara;

            return View();
        }
        [HttpPost] // aşağıdaki metot post işleminde çalışsın
        public IActionResult Index(string text1, string ddlListe, bool cbOnay)
        {
            ViewBag.BirinciYontem = "1. Yöntemle(Parametrelerden gelen veriler)";
            ViewBag.Mesaj = "Textbox dan gelen veri : " + text1;
            ViewBag.MesajListe = "ddlListe den gelen veri : " + ddlListe;
            TempData["Tdata"] = "cbOnay dan gelen değer : " + cbOnay;

            return View();
        }
    }
}
