namespace SchoolManagment.Models.ViewModels
{
  public class SummaryViewModel
  {
    public IEnumerable<Student> Items { get; set; }
    public PagingInfo PagingInfo { get; set; }
    public string? SearchString { get; set; }
  }
}