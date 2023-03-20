using System.ComponentModel.DataAnnotations;

namespace P013AspNetMVCEgitim.Models
{
    public class Uye
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad Alanı Boş Geçilemez!"), StringLength(50)] // StringLength ile ad alanına kaç karakter gönderilebileceğini sınırlayabiliriz
        public string Ad { get; set; }
        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez!"), StringLength(50)]
        public string Soyad { get; set; }
        [EmailAddress(ErrorMessage = "Geçersiz Mail Girdiniz!"), StringLength(50)]
        public string? Email { get; set; }
        [Phone(ErrorMessage = "Geçersiz Mail Girdiniz!"), StringLength(50)]
        public string? Telefon { get; set; }
        [Display(Name = "TC Kimlik Numarası")] // Ekranda TcKimlikNo yerine TC Kimlik Numarası yazsın
        [MinLength(11, ErrorMessage = "{0} 11 Karakter Olmalıdır!")]
        [MaxLength(11, ErrorMessage = "{0} 11 Karakter Olmalıdır!")]
        public string? TcKimlikNo { get; set; }
        [Display(Name = "Doğum Tarihi")]
        public DateTime? DogumTarihi { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        public string? KullaniciAdi { get; set; }
        [Display(Name = "Şifre")]
        public string? Sifre { get; set; }
        [Display(Name = "Şifre Tekrar")]
        public string? SifreTekrar { get; set; }
    }
}
