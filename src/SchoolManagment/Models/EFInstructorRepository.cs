using Microsoft.EntityFrameworkCore;

namespace SchoolManagment.Models
{
  public class EFInstructorRepository : ISchoolRepository<Student>
  {
    private readonly SchoolDbContext _context;

    public IQueryable<Student> Items => _context.Teachers.AsNoTracking();

    public EFInstructorRepository(SchoolDbContext ctx)
    {
      _context = ctx;
    }

    public async Task SaveAsync(Student teacher)
    {
      if(_context.Teachers.Any(t => teacher.Id == teacher.Id))
      {
        var result = await Items.FirstOrDefaultAsync(s => s.Id == teacher.Id);
          
        if(result != null)
          _context.Students.Update(teacher);
      }
      else
      {
        await _context.AddAsync(teacher);
      }

      await _context.SaveChangesAsync();
    }

    public Task<Student?> GetByIdAsync(int id)
    {
      return _context.Students.FirstOrDefaultAsync(s => s.Id == id);
    }

    public async Task RemoveByIdAsync(int id)
    {
      var studentToDelete = await GetByIdAsync(id);
      
      if(studentToDelete != null) 
      {
        _context.Students.Remove(studentToDelete);
        await _context.SaveChangesAsync();
      }
    }

    public async Task SaveChangesAsync()
    {
      await _context.SaveChangesAsync();
    }

    public bool Exist(int id)
    {
      return _context.Students.Any(s => s.Id == id);
    }
  }
}