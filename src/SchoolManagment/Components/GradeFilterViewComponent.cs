using Microsoft.AspNetCore.Mvc;
using SchoolManagment.Models;

namespace SchoolManagment.Components
{
  public class GradeFilterViewComponent : ViewComponent
  {
    private IStudentRepository _repository;

    public GradeFilterViewComponent(IStudentRepository repo)
    {
      _repository = repo;
    }
    
    public IViewComponentResult Invoke()
    {
      return View(_repository.Students
        .Select(s => s.GradeLevels)
        .Distinct()
        .OrderBy(s => s));
    }
  }
}