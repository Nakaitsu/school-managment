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
        Client newClient = model.Role == UserRole.Student ?
          new Student() : new Teacher();
        
        newClient.FirstName = model.FirstName;
        newClient.LastName = model.LastName;
        newClient.Birthdate = model.Birthdate;
        newClient.Email = model.Email;
        newClient.Login = model.Login;
        newClient.Password = model.Password;
        newClient.Role = model.Role;

        if(model.Role == UserRole.Student)
        {
          return RedirectToActionPreserveMethod("Create", "Student", newClient);

          // retorna para o portal do aluno
          // return RedirectToActionPreserveMethod("Create", "Instructor", "Portal", newClient);
        }
        else if(model.Role == UserRole.Teacher)
        {
          // retorna para o portal do professor
          return RedirectToActionPreserveMethod("Create", "Instructor", newClient);
        }
        
        // posso salvar ele e 
        // salvar o student na base de dados
        // redirecionar ele para o portal do aluno
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