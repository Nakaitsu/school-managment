using Microsoft.AspNetCore.Mvc;

namespace SchoolManagment.Controllers
{
  public class HomeController : Controller
  {
    public ViewResult Index() => View();
  }
}