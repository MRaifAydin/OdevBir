using Microsoft.EntityFrameworkCore;
using OdevBir.Business;
using OdevBir.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// Add connection strings.
builder.Services.AddDbContext<NorthwndContext>(options =>
                 options.UseSqlServer(builder.Configuration.GetConnectionString("MsSql")));

BusinessDIModule.Inject(builder.Services, builder.Configuration);

var app = builder.Build();


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
