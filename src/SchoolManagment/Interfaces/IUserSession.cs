using SchoolManagment.Models;

namespace SchoolManagment.Interfaces
{
  public interface IUserSession
  {
    void CreateSession(User user);

    void RemoveSession();

    User GetUser();
  }
}