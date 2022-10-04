namespace SchoolManagment.Models
{
  public class Teacher : Client
  {
    public int Id { get; set; }
    public ICollection<Turma> Turmas { get; set; }
  }
}