using SchoolManagment.Enums;

namespace SchoolManagment.Models
{
  public class Student
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public DateTime Birthday { get; set; }
    public Grades Grade { get; set; }
  
    public Student(string fisrtName, string lastName, DateTime birthday, Grades grade)
    {
      FirstName = fisrtName;
      LastName = lastName;
      Birthday = birthday;
      Grade = grade;
    }
  }
}