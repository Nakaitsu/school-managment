namespace SchoolManagment.Models
{
  public class Instructor : Client
  {
    public int Id { get; set; }
    public ICollection<Classroom> Classrooms { get; set; }
  }
}