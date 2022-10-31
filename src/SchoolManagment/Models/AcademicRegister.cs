namespace SchoolManagment.Models 
{
  public class AcademicRegister
  {
    [Key]
    public int Id { get; set; }

    public int StudentId { get; set; }

    public int AcademicRegisterId { get; set; }

    public Role Role { get; set; }

    public AcademicRegister(int studentId, int academicEntityId, Role role) {
      studentId = studentId;
      AcademicRegisterId = academicEntityId;
      Role = role;
    }
  }
}