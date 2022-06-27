using Microsoft.EntityFrameworkCore;
using SchoolManagment.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddDbContext<SchoolDbContext>(opts => {
  opts.UseSqlServer(
    builder.Configuration["ConnectionStrings:SchoolDbConnection"]
  );
});
builder.Services.AddScoped<ISchoolRepository, EFSchoolRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();