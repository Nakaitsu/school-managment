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
builder.Services.AddScoped<IStudentRepository, EFStudentRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute("SummaryFilterAndPage",
  "{filter}/Page{page:int}");

app.MapControllerRoute("SummaryPage", "Page{page:int}");

app.MapControllerRoute("Filter", "{filter}");

app.MapControllerRoute("Default",
  "{controller}/{action}/{id}",
  new { Controller = "Home", Action = "Index"});

app.MapDefaultControllerRoute();

SeedData.EnsurePopulated(app);
app.Run();