namespace SchoolManagment.Helpers
{
  public static class DateTimeExtensions
  {
    public static string GetRelativeTime(this DateTime dateTime)
    {
      var relativeTime = DateTime.Now - dateTime;
      string timeString = "Undefined time";

      if(relativeTime.Minutes <= 0)
        timeString = "Just now";
      else if (relativeTime.Minutes > 0 && relativeTime.Hours == 0)
        timeString = $"{relativeTime.Minutes} minutes ago";
      else if(relativeTime.Hours > 0)
        timeString = $"{relativeTime.Hours}:{relativeTime.Minutes} ago";

      return timeString;
    }

    public static int GetAge(this DateTime dateTime)
    {
      return DateTime.Now.Year - dateTime.Year;
    }
  }
}