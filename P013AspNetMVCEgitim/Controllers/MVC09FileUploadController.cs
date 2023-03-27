using Microsoft.AspNetCore.Mvc;

namespace P013AspNetMVCEgitim.Controllers
{
    public class MVC09FileUploadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(IFormFile? Image) // ön tüzdeki file elementinin ismini buradaki IFormFile parametresine veriyoruz! IFormFile? a ? koymamızın sebebi post yapılırken kullanıcı resim yüklemeyebilir, sadece inputlardan veri göndermek isteyebilir.
        {
            if (Image is not null)
            {
                string directory = Directory.GetCurrentDirectory() + "/wwwroot/Images/" + Image.FileName; // dosyanın yükleneceği dizini belirledik
                using var stream = new FileStream(directory, FileMode.Create); // seçilen dosyayı pc den sunucuya gönderecek bir akış oluşturduk
                Image.CopyTo(stream); // akışı kullanarak resmi sunucuya kopyaladık
                TempData["Resim"] = Image.FileName;
            }
            return View();
        }
    }
}
