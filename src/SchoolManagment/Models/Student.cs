using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagment.Models
{
  public class Student : Client
  {
    public int Id { get; set; }

    public int RA { get; set; }
    
    public DateTime EnrollmentDate { get; set; }

    public ICollection<Enrollment> Enrollments { get; set; }

    public Student(string firstName, string lastName, DateTime birthdate) 
      : base(firstName, lastName, birthdate) 
    {
    }

    public Student()
    {
    }
  }
}