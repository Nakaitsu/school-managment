using Microsoft.EntityFrameworkCore;

namespace SchoolManagment.Models
{
  public class EFCourseRepository : ISchoolRepository<Course>
  {
    private readonly SchoolDbContext _context;
    
    public IQueryable<Course> Items => _context.Courses;

    public EFCourseRepository(SchoolDbContext context)
    {
      _context = context;
    }

    public bool Exist(int id)
    {
      return _context.Courses.Any(c => c.CourseID == id);
    }

    public Task<Course?> GetByIdAsync(int id)
    {
      return _context.Courses.FirstOrDefaultAsync(c => c.CourseID == id);
    }

    public async Task RemoveByIdAsync(int id)
    {
      var courseToDelete = await GetByIdAsync(id);
      
      if(courseToDelete != null)
      {
        _context.Courses.Remove(courseToDelete);
        await _context.SaveChangesAsync();
      }
    }

    public Task<int> SaveAsync(Course model)
    {
      throw new NotImplementedException();
    }

    public Task SaveChangesAsync()
    {
      throw new NotImplementedException();
    }
    
  }
}