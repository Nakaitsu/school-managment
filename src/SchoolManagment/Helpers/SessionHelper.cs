using System.Text.Json;

namespace SchoolManagment.Helpers
{
  public static class SessionHelper
  {
    public static void SetJson<T>(this ISession session, string key, T value) where T : class 
    {
      session.SetString(key, JsonSerializer.Serialize(value));
    }

    public static T GetJson<T>(this ISession session, string key) where T : class
    {
      var sessionData = session.GetString(key);
      return sessionData == null 
        ? default(T) : JsonSerializer.Deserialize<T>(sessionData);
    }

  }
}