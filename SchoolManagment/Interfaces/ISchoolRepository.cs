namespace SchoolManagment.Models
{
  public interface ISchoolRepository
  {
    IQueryable<Student> Students { get; }
  }
}