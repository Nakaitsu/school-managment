using SchoolManagment.Helpers;
using SchoolManagment.Interfaces;

namespace SchoolManagment.Models
{
  public class UserSession : IUserSession
  {
    private readonly IHttpContextAccessor? _httpContext;

    public ISession Session { get; set; }
    
    public UserSession(IServiceProvider services)
    {
      _httpContext = services.GetRequiredService<IHttpContextAccessor>();
      Session = _httpContext.HttpContext.Session;
    }
    
    public void CreateSession(User user)
    {
      Session.SetJson<User>("loggedUser", user);
    }

    public User GetUser()
    {
      var userData = Session.GetJson<User>("loggedUser");

      if(userData == null) return null;

      return userData;
    }

    public void RemoveSession()
    {
      Session.Remove("loggedUser");
    }
  }
}