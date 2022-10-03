using System.ComponentModel;
using System.Reflection;

namespace SchoolManagment.Helpers
{
  public static class EnumExtensions
  {
    public static string GetDescription(this Enum genericEnum)
    {
      Type enumType = genericEnum.GetType();
      MemberInfo[] memberInfo = enumType.GetMember(genericEnum.ToString());

      if(memberInfo != null && memberInfo.Length > 0)
      {
        var attributes = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

        if(attributes != null && attributes.Count() > 0)
        {
          return ((DescriptionAttribute)attributes.ElementAt(0)).Description;
        }
      } 

      return genericEnum.ToString();
    }
  }
}