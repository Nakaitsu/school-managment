using Microsoft.AspNetCore.Mvc;
using SchoolManagment.Interfaces;
using SchoolManagment.Models;
using SchoolManagment.Models.ViewModels;

namespace SchoolManagment.Controllers
{
  public class UserController : Controller
  {
    private readonly IUserSession _session;
    

    private readonly ISchoolRepository<Student> _students;
    private readonly ISchoolRepository<Teacher> _teachers;
    // Essa controler precisa criar student e instructor
    // um repositorio para manipular os 2?
    // ou dois repositorios distintos ?
    // to fazendo errado ? 
    public UserController(IUserSession session, ISchoolRepository<Teacher> teacherCtx, ISchoolRepository<Student> studentCtx)
    {
      _session = session;
      _students = studentCtx;
      _teachers = teacherCtx;
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
        var newClient = new Client(
          model.FirstName,
          model.LastName,
          model.Birthdate
        )

        newClient.Email = model.Email;
        newClient.Login = model.Login;
        newClient.Password = model.Password;
        newClient.Role = model.Role;
        
        if(model.Role == UserRole.Student)
        {
          _students.SaveAsync((Student)newClient);

          // retorna para o portal do aluno
        }
        else if(model.Role == UserRole.Teacher)
        {
          _teachers.SaveAsync((Teacher)newClient);

          // retorna para o portal do professor
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