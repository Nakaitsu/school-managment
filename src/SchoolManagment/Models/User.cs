using System.ComponentModel.DataAnnotations;

namespace SchoolManagment.Models
{
  public class User
  {
    [Key]
    public int Id { get; set;}

    public string Login { get; set; }

    public string Password { get; set; }

    [StringLength(70)]
    public string Email { get; set; }

    public UserRole Role { get; set; }

    public User(string login, string email, string password)
    {
      Login = login;
      Password = password;
      Email = email;
    }
  }

  enum UserRole
  {
    Student, Teacher, Admin 
  }
}
