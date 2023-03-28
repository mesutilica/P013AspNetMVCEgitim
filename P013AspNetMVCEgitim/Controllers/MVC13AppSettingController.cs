using Microsoft.AspNetCore.Mvc;

namespace P013AspNetMVCEgitim.Controllers
{
    public class MVC13AppSettingController : Controller
    {
        private readonly IConfiguration _configuration; // Dependency injection ile constructor da oluşturmak için _configuration a sağ tık > açılan menüden ampul simgesine tıklayıp açılan menüden generate constructor diyerek oluşturabiliriz.

        public MVC13AppSettingController(IConfiguration configuration) // DI
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            TempData["Email"] = _configuration["Email"];
            TempData["MailSunucu"] = _configuration["MailSunucu"];
            TempData["KullaniciAdi"] = _configuration["MailKullanici:Username"]; // json daki MailKullanici altındaki Username değerine : ile ulaşıyoruz
            TempData["Sifre"] = _configuration.GetSection("MailKullanici:Password").Value; // GetSection metoduyla da veriyi çekebiliriz
            return View();
        }
    }
}
