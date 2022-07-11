namespace SchoolManagment.Models
{
  public interface IStudentRepository
  {
    IQueryable<Student> Students { get; }

    Task SaveAsync(Student student);

    Task RemoveByIdAsync(int id);

    Task<Student?> GetByIdAsync(int id);

    bool Exist(int id);

    Task SaveChangesAsync();
  }
}