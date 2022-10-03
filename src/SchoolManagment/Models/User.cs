using System.ComponentModel.DataAnnotations;

namespace SchoolManagment.Models
{
  public class User
  {
    public string Login { get; set; }
    public string Password { get; set; }

    [StringLength(70)]
    public string Email { get; set; }
    public UserRole Role { get; set; }

    public User(string login, string password)
    {
      Login = login;
      Password = password;
    }
  }

  public enum UserRole
  {
    Student, Teacher, Admin 
  }
}
