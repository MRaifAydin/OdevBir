using Microsoft.EntityFrameworkCore;
using OdevBir.Conversion;
using OdevBir.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Add connection strings.
builder.Services.AddDbContext<NorthwndContext>(options =>
                 options.UseSqlServer(builder.Configuration.GetConnectionString("MsSql")));

ConversionDIModule.Inject(builder.Services);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
