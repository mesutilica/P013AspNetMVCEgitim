using Microsoft.AspNetCore.Mvc;
using P013AspNetMVCEgitim.Models;

namespace P013AspNetMVCEgitim.Controllers
{
    public class MVC05ModelValidationController : Controller
    {
        UyeContext context = new UyeContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UyeListesi()
        {
            var model = context.Uyes.ToList(); // context içinde yer alan Uyes tablosundaki verileri listele ve model isimli değişkene aktar
            return View(model); // view sayfasına model bu şekilde gönderiliyor
        }
        public IActionResult YeniUye()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniUye(Uye uye)
        {
            if (ModelState.IsValid) // eğer parantez içerisinde gönderilen uye nesnesi validasyon kurallarına uygunsa
            {
                // bu boktaki kodları çalıştır. Mesela gönderilen uye nesnesini veritabanına ekle
                context.Uyes.Add(uye); // View dan gönderilen uye nesnesini context üzerindeki uyes tablosuna ekle
                context.SaveChanges(); // üst satırdaki ekleme işlemini kaydet.
                return RedirectToAction("UyeListesi");
            }
            else
            {
                ModelState.AddModelError("", "Lütfen Zorunlu Alanları Doldurunuz!");
            }
            return View();
        }
        public IActionResult UyeDuzenle(int id)
        {
            var kayit = context.Uyes.Find(id); // adres çubuğundaki route üzerinden gönderilen id ile eşleşen kaydı bul
            return View(kayit);
        }
        [HttpPost]
        public IActionResult UyeDuzenle(Uye uye)
        {
            if (ModelState.IsValid) // eğer parantez içerisinde gönderilen uye nesnesi validasyon kurallarına uygunsa
            {
                context.Uyes.Update(uye); // View dan gönderilen uye nesnesini güncelle
                context.SaveChanges(); // üst satırdaki ekleme işlemini kaydet.
                return RedirectToAction("UyeListesi");
            }
            else
            {
                ModelState.AddModelError("", "Lütfen Zorunlu Alanları Doldurunuz!");
            }
            return View();
        }
        public IActionResult UyeSil(int id)
        {
            var kayit = context.Uyes.Find(id); // adres çubuğundaki route üzerinden gönderilen id ile eşleşen kaydı bul
            return View(kayit);
        }
        [HttpPost]
        public IActionResult UyeSil(Uye uye)
        {
            try
            {
                context.Uyes.Remove(uye);
                context.SaveChanges(); // üst satırdaki ekleme işlemini kaydet.
                return RedirectToAction("UyeListesi");
            }
            catch (Exception hata)
            {
                ModelState.AddModelError("", "Hata Oluştu!" + hata.Message);
            }
            return View(uye);
        }
    }
}
