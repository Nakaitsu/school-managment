using System.ComponentModel.DataAnnotations;

namespace SchoolManagment.Models 
{
  public class StudentAcademicRegister
  {
    [Key]
    public int Id { get; set; }

    public int UserId { get; set; }

    public int StudentId { get; set; }

    public User User { get; set; }
    public Student Student { get; set; }

    public StudentAcademicRegister(int userId, int studentId) {
      UserId = userId;
      StudentId = studentId;
    }
  }
}