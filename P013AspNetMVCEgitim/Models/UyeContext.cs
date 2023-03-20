using Microsoft.EntityFrameworkCore;

namespace P013AspNetMVCEgitim.Models
{
    // InMemoryDb kullanabilmek için projeye sağ tık nuget package manager menüsünü aç
    // Oradan Installed yüklü olan paketleri gösterir. Browse sekmesinden EntityFrameworkCore.InMemory paketini ve EntityFrameworkCore.Design paketlerini yüklüyoruz
    public class UyeContext : DbContext
    {
        public DbSet<Uye> Uyes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // EntityFrameworkCore veritabanı işlemleri için yapılandırma ayarlarını yapabildiğimiz metot
            optionsBuilder.UseInMemoryDatabase("InMemoryDb"); // bilgisayarımızın ram belleğini sanal veritabanı olarak kullanmasını sağlayan ayarı yaptık.
            // bu ayardan sonra projemizin program.cs classına gidip bu UyeContext sınıfını servis olarak ekliyoruz.
            base.OnConfiguring(optionsBuilder);
        }
    }
}
