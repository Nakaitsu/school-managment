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
    
    public GradeLevels GradeLevel { get; set; }
    
    public DateTime EnrollmentDate { get; set; }

    public ICollection<Enrollment> Enrollments { get; set; }

    public Student(string firstName, string lastName, DateTime birthdate, GradeLevels gradeLevel)
    {
      FirstName = firstName;
      LastName = lastName;
      Birthdate = birthdate;
      GradeLevel = gradeLevel;
    }

    public Student() 
    {
    }
  }
}