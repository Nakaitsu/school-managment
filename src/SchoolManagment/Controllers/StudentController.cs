using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagment.Helpers;
using SchoolManagment.Models;
using SchoolManagment.Models.ViewModels;

namespace SchoolManagment.Controllers
{
  public class StudentController : Controller
  {
    private readonly ISchoolRepository<Student> _repository;
    public int PageItems = 10;

    public StudentController(ISchoolRepository<Student> repo)
    {
      _repository = repo;
    }

    public ViewResult Index(string? search, int page = 1)
    {
      var result = _repository.Items;
      
      if (!String.IsNullOrEmpty(search))
      {
        result = result
          .Where(s => s.FirstName.Contains(search) || 
            s.LastName.Contains(search) || 
            (!String.IsNullOrEmpty(s.Email) && s.Email.Contains(search)));

        return View(new SummaryViewModel {
          Items = result
            .OrderBy(s => s.Id)
            .Skip((page - 1) * PageItems)
            .Take(PageItems),
          PagingInfo = new PagingInfo {
            CurrentPage = page,
            ItemsPerPage = PageItems,
            TotalItems = result.Count()
          },
          SearchString = search
        });
      }

      return View(new SummaryViewModel {
        Items = result
          .OrderBy(s => s.Id)
          .Skip((page - 1) * PageItems)
          .Take(PageItems),
        PagingInfo = new PagingInfo {
          CurrentPage = page,
          ItemsPerPage = PageItems,
          TotalItems = result.Count()
        },
        SearchString = search
      });
    }

    [HttpGet]
    public ViewResult Create()
    {
      return View();
    }

    [HttpPost, ActionName("Create")]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> CreatePost(CreateStudentViewModel model)
    {
      if (ModelState.IsValid)
      {
        await _repository.SaveAsync(model.ToStudent()); // tirar esse metodo

        if(Request.Headers["Referer"].ToString().ToLower().Contains("student")) {
          TempData.SetJson<Notification>("Notifications",
            new Notification(
              "Record saved",
              "The record was successfully saved in database",
              "Success"));
          TempData.SetJson<Notification>("Notifications",
            new Notification(
              "TEST",
              "Voltou porque tem student na rota",
              "Warning"));

          return RedirectToAction(nameof(Index));
        }
        else
        {
          TempData.SetJson<Notification>("Notifications",
            new Notification(
              "TEST",
              "Salvou e voltou para a home page",
              "Warning"));
          return RedirectToAction("Index", "Home");
          // redirecionar para o portal
        }
      }

      TempData.SetJson<Notification>("Notifications",
        new Notification(
          "Error while saving",
          "An error occorred while trying to save the student",
          "Danger"));
      return View(model);
    }

    [HttpGet]
    public async Task<ActionResult> Edit(int id)
    {
      if (_repository.Exist(id))
      {
        var student = await _repository.GetByIdAsync(id);

        return View(student);
      }

      return NotFound();
    }

    [HttpPost, ActionName("Edit")]
    [AutoValidateAntiforgeryToken]
    public async Task<ActionResult> EditPost(Student student)
    {
      await _repository.SaveAsync(student);
      TempData.SetJson<Notification>("Notifications",
        new Notification(
          "List Updated",
          "A student record was been updated",
          "Success"));
      return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<ActionResult> Delete(int id)
    {
      if (_repository.Exist(id))
      {
        var student = await _repository.GetByIdAsync(id);

        return View(student);
      }

      return NotFound();
    }

    [HttpPost]
    [ActionName("Delete")]
    public async Task<ActionResult> DeletePost(int id)
    {
      await _repository.RemoveByIdAsync(id);
      return RedirectToAction(nameof(Index));
    }

    public ViewResult Info(int id)
    {
      return View("Details", _repository.Items
        .Include(s => s.Enrollments)
          .ThenInclude(e => e.Course)
        .AsNoTracking()
        .FirstOrDefault(s => s.Id == id)
      );
    }

  }
}