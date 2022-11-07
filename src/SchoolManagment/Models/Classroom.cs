namespace SchoolManagment.Models
{
  public class Classroom
  {
    public int Id { get; set; }
    public int InstructorId { get; set; }
    public int CourseId { get; set; }
    public ICollection<Student> Students { get; set; }

    public Instructor Instructor { get; set; }
    public Course Course { get; set; }
  }
}
