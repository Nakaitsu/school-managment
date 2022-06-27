namespace SchoolManagment.Models
{
  public class Notification
  {
    public string Title { get; set; }
    public string Message { get; set; }
    private string _type;
    public string Type {
      get { return _type; }
      set { _type = value?.ToLower() ?? "Secondary".ToLower();} 
    }
    public DateTime Time { get; set; }

    public Notification(string title, string message, string type)
    {
      Title = title;
      Message = message;
      Type = type;
      Time = DateTime.Now;
    }

    public Notification() {}
  }
}