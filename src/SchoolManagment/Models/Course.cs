using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagment.Models
{
  public class Course
  {
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int CourseID { get; set; }
    public string Title { get; set; }

    public ICollection<Enrollment> Enrollment { get; set; }
  }
}