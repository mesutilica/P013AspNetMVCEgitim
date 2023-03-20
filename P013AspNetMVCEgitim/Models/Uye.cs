using System.ComponentModel.DataAnnotations;

namespace P013AspNetMVCEgitim.Models
{
    public class Uye
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad Alanı Boş Geçilemez!")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez!")]
        public string Soyad { get; set; }
        public string? Email { get; set; }
        public string? Telefon { get; set; }
        public string? TcKimlikNo { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string? KullaniciAdi { get; set; }
        public string? Sifre { get; set; }
        public string? SifreTekrar { get; set; }
    }
}
