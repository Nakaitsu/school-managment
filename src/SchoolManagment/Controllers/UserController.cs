using Microsoft.AspNetCore.Mvc;
using SchoolManagment.Interfaces;
using SchoolManagment.Models;
using SchoolManagment.Models.ViewModels;

namespace SchoolManagment.Controllers
{
  public class UserController : Controller
  {
    private readonly IUserSession _session;
    
    // Essa controler precisa criar student e instructor
    // um repositorio para manipular os 2?
    // ou dois repositorios distintos ?
    // to fazendo errado ? 
    public UserController(IUserSession session)
    {
      _session = session;
    }

    [HttpPost]
    public IActionResult Signin(User user)
    {
      return NotFound();
    }

    [HttpGet]
    public IActionResult Signup()
    {
      return View();
    }

    [HttpPost]
    [ActionName("SignUp")]
    public IActionResult SignupPost(SignUpViewModel model)
    {
      if(ModelState.IsValid)
      {
        if(model.Role == UserRole.Student)
        {
          Student newStudent = new Student(
            model.FirstName,
            model.LastName,
            model.Birthdate
          );

          newStudent.Email = model.Email;
          newStudent.Login = model.Login;
          newStudent.Password = model.Password;
          newStudent.Role = model.Role;

          // posso salvar ele e 

          // salvar o student na base de dados
          // redirecionar ele para o portal do aluno
        }
        else if(model.Role == UserRole.Teacher)
        {

        }
      }
      
      return View(model); // Tira isso
    }

    public IActionResult Info()
    {
      return NotFound();
    }

    public IActionResult ResetPassword()
    {
      return NotFound();
    }

    public IActionResult Logout() 
    {
      _session.RemoveSession();

      return RedirectToAction("Index", "Home");
    }
  }
}