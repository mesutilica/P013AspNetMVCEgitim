using P013AspNetMVCEgitim.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<UyeContext>(); // bu satýrý sanal veritabaný kullanabilmek için ekledik

builder.Services.AddSession(); // uygulamada session kullanabilmek için bu satýrý ekliyoruz

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection(); // uygulama http isteklerini https ile güvenli baðlantýya yönlendirmeyi desteklesin.
app.UseStaticFiles(); // uygulama statik dosyalarý(wwwroot klasöründekiler) desteklesin

app.UseRouting(); // uygulama routing ile yönlendirmeyi kullansýn.

app.UseSession(); // uygulamada session kullanabilmek için bu satýrý ekliyoruz

app.UseAuthentication(); // uygulama kullanýcý giriþ sistemini aktif etsin
app.UseAuthorization(); // uygulama kullanýcý yetkilendirme(admin, user vb.) sistemini aktif etsin

app.MapControllerRoute( // area nýn çalýþmasý için bu route ayarýný buraya ekledik.
            name: "admin",
            pattern: "{area:exists}/{controller=Default}/{action=Index}/{id?}"
          );

app.MapControllerRoute( // uygulama nýn kullanacaðý routing yönlendirme ayarý
    name: "default", // route adý
    pattern: "{controller=Home}/{action=Index}/{id?}"); // eðer adres çubuðundan uygulamaya bir controller adý ve action adý gönderilmezse varsayýlan olarak Home controller ý ve içindeki Index isimli action ý çalýþtýrsýn. id deðeri ise ? iþareti ile parametrik yani isteðe baðlý belirtilmiþ.

app.Run(); // uygulamayý yukardaki ayarlarý kullanarak çalýþtýr.
