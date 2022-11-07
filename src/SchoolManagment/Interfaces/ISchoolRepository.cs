namespace SchoolManagment.Models
{
  public interface ISchoolRepository<T> where T : class
  {
    IQueryable<T> Items { get; }

    Task<int> SaveAsync(T model);

    Task RemoveByIdAsync(int id);

    Task<T?> GetByIdAsync(int id);

    bool Exist(int id);

    Task SaveChangesAsync();
  }
}