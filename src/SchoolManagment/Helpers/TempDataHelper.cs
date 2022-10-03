using System.Text.Json;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace SchoolManagment.Helpers
{
  public static class TempDataHelper
  {
    public static void SetJson<T>(this ITempDataDictionary tempData, string key, T value) where T : class
    {
      tempData[key] = JsonSerializer.Serialize(value);
    }

    public static T GetJson<T>(this ITempDataDictionary tempData, string key) where T : class
    {
      tempData.TryGetValue(key, out object o);
      return o == null ? null 
        : JsonSerializer.Deserialize<T>((string)o);
    }
  }
}