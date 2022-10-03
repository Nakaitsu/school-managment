using Microsoft.AspNetCore.Mvc;
using SchoolManagment.Models;

namespace SchoolManagment.Controllers
{
  public class HomeController : Controller
  {
    private readonly ISchoolRepository<Course> _repository;

    public HomeController(ISchoolRepository<Course> repo)
    {
      _repository = repo;
    }
    
    public ViewResult Index()
    {
      return View(_repository.Items
        .Take(6));
    }
  }
}