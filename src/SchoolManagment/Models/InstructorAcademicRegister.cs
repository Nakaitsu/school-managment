using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagment.Models
{
  public class InstructorAcademicRegister
  {
   [Key]
    public int Id { get; set; }

    public int UserId { get; set; }

    public int InstructorId { get; set; }

    public User User { get; set; }
    public Instructor Instructor { get; set; }

    public InstructorAcademicRegister(int userId, int instructorId) {
      UserId = userId;
      InstructorId = instructorId;
    }
  }   
}