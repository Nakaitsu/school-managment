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
        User newUser = new User(model.Login, model.Email, model.Password);
        newUser.Role = model.Role;

        // armazena o usuario na sessao como logado
        // redireciona para um portal e la eu pego o id do usuario e vinculo no RA
        session.CreateSession(newUser);
        
        if(model.Role == UserRole.Student)
        {
          return RedirectToActionPreserveMethod("Create", "Student", newUser);
        }
        else if(model.Role == UserRole.Teacher)
        {
          return RedirectToActionPreserveMethod("Create", "Instructor", newUser);
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