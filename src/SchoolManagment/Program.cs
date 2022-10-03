using Microsoft.EntityFrameworkCore;
using SchoolManagment.Interfaces;
using SchoolManagment.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddDbContext<SchoolDbContext>(opts => {
  opts.UseSqlServer(
    builder.Configuration["ConnectionStrings:SchoolDbConnection"]
  );
});
builder.Services.AddScoped<ISchoolRepository<Student>, EFStudentRepository>();
builder.Services.AddScoped<ISchoolRepository<Course>, EFCourseRepository>();
builder.Services.AddScoped<IUserSession, UserSession>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddSession(config => {
  config.Cookie.HttpOnly = true;
  config.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();
app.UseSession();

app.MapControllerRoute("SummaryFilterAndPage",
  "{controller}/{action}/{filter}/Page{page:int}");

app.MapControllerRoute("SummaryPage",
  "{controller}/{action}/Page{page:int}");

app.MapControllerRoute("Filter",
  "{controller}/{action}/{filter}");

app.MapControllerRoute("Default",
  "{controller}/{action}/{id}",
  new { Controller = "Home", Action = "Index"});

app.MapDefaultControllerRoute();

SeedData.EnsurePopulated(app);
app.Run();