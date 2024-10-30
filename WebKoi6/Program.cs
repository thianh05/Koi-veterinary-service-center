using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using WebKoi6.BLL;
using WebKoi6.DAL;
using WebKoi6.DAL.Base;
using WebKoi6.DAL.Models;
using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromHours(24);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});
builder.Services.AddMvc();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<KvscContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
/*builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));*/
builder.Services.AddScoped<IBaseDAL, IplBaseDAL>();
builder.Services.AddScoped<IBaseBLL, IplBaseBLL>();
builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();
builder.Services.AddOptions();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapAreaControllerRoute(
           name: "Admin",
           areaName: "Admin",
           pattern: "Admin/{controller=Home}/{action=Index}/{id?}");
app.Run();
