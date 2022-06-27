using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SchoolManagment.Infrastructure;
using SchoolManagment.Models;

namespace SchoolManagment.Controllers;

public class HomeController : Controller
{
  private ISchoolRepository _repository;

  public HomeController(ISchoolRepository repo)
  {
    _repository = repo;
  }

  public ViewResult Index(string? Search)
  {
    if (!String.IsNullOrEmpty(Search))
    {
      var search = Search.ToLower();

      return View(StudentRepository.students
        .Where(s => s.FirstName.Contains(search) ||
          s.LastName.Contains(search) ||
          (!String.IsNullOrEmpty(s.Email) && s.Email.Contains(search)))
      );
    }

    return View(StudentRepository.students);
  }

  [HttpGet]
  public ViewResult Create()
  {
    return View();
  }

  [HttpPost]
  [ActionName("Create")]
  public ActionResult CreatePost(StudentViewModel model)
  {
    if (ModelState.IsValid)
    {
      StudentRepository.Save(model.ToStudent());
      TempData.SetJson<Notification>("Notifications",

        new Notification(
          "Record saved",
          "The record was successfully saved in database",
          "Success"));  
      return RedirectToAction();
    }

    TempData.SetJson<Notification>("Notifications",
      new Notification(
        "Error while saving",
        "An error occorred while trying to save the student",
        "Danger"));
    return View(model);
  }

  [HttpGet]
  public ActionResult Edit(int id)
  {
    if (StudentRepository.Exist(id))
    {
      var student = StudentRepository.students
        .First(s => s.Id == id);

      return View(student);
    }

    TempData.SetJson<Notification>("Notifications",
      new Notification(
        "Missing information",
        "Student record not found",
        "Warning"));
    return RedirectToAction("Index");
  }

  [HttpPost]
  [ActionName("Edit")]
  public ActionResult EditPost(StudentViewModel model)
  {
    if(ModelState.IsValid){
      StudentRepository.Save(model.ToStudent());
      return RedirectToAction("Index");
    }

    return View(model); 
  }

  [HttpGet]
  public IActionResult Delete(int id)
  {
    if (StudentRepository.Exist(id))
    {
      var student = StudentRepository.students
        .First(s => s.Id == id);

      return View("Delete", student);
    }

    TempData.SetJson<Notification>("Notifications",
      new Notification(
        "Missing information",
        "Student record not found",
        "Warning"));
    return RedirectToAction("Index");
  }

  [HttpPost]
  [ActionName("Delete")]
  public IActionResult DeletePost(int id)
  {
    StudentRepository.RemoveById(id);
    return RedirectToAction("Index");
  }

  public IActionResult Student(int id)
  {
    return View();
  }
}
