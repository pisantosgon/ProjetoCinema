using Microsoft.EntityFrameworkCore;
using ProjetoCinema.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

/*builder.Services.AddDbContext<Contexto> //Pietra
    (options => options.UseSqlServer("Data Source=SB-1490642\\SQLSENAI;Initial Catalog = ProjetoCinema;Integrated Security = True;TrustServerCertificate = True"))*/

/*builder.Services.AddDbContext<Contexto> //Heloísa
    (options => options.UseSqlServer("Data Source=SB-1490640\\SQLSENAI;Initial Catalog = ProjetoCinema;Integrated Security = True;TrustServerCertificate = True"));*/


/*builder.Services.AddDbContext<Contexto> // Maria Heloísa
    (options => options.UseSqlServer("Data Source=SB-1490647\\SQLSENAI;Initial Catalog = ProjetoCinema;Integrated Security = True;TrustServerCertificate = True"));*/


/*builder.Services.AddDbContext<Contexto> //  Maria Eduarda
    (options => options.UseSqlServer("Data Source=SB-1490648\\SQLSENAI;Initial Catalog = ProjetoCinema;Integrated Security = True;TrustServerCertificate = True"));*/


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
