namespace SchoolManagment.Models
{
  public class Student : Client
  {
    public int Id { get; set; }
    public ICollection<Turma> Turmas { get; set; }
  }
}