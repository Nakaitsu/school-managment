using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SchoolManagment.Enums;

namespace SchoolManagment.Models
{
  public class Student
  {
    public int Id { get; set; }
    
    [StringLength(50)]
    public string FirstName { get; set; }
    
    [StringLength(50)]
    public string LastName { get; set; }
    
    [StringLength(70)]
    public string? Email { get; set; }
    
    [StringLength(11)]
    public string? Phone { get; set; }
    
    [DataType(DataType.Date)]
    [Column(TypeName = "Date")]
    public DateTime Birthdate { get; set; }
    
    public GradeLevels GradeLevels { get; set; }
    
    public DateTime EnrollmentDate { get; } = DateTime.Now;

    public Student(string firstName, string lastName, DateTime birthdate, GradeLevels grade)
    {
      FirstName = firstName;
      LastName = lastName;
      Birthdate = birthdate;
      GradeLevels = grade;
    }

    public Student() {}
  }
}