using Microsoft.EntityFrameworkCore;

namespace SchoolManagment.Models
{
  public class EFTeacherRepository : ISchoolRepository<Teacher>
  {
    private readonly SchoolDbContext _context;

    public IQueryable<Teacher> Items => _context.Teacher.AsNoTracking();

    public EFStudentRepository(SchoolDbContext ctx)
    {
      _context = ctx;
    }

    public async Task SaveAsync(Teacher teacher)
    {
      if(_context.Teacher.Any(t => t.Id == teacher.Id);
      {
        var result = await _context.Teacher
          .AsNoTracking().FirstOrDefaultAsync(t => t.Id == student.Id);
          
        if(result != null)
          _context.Teacher.Update(teacher);
      }
      else
      {
        await _context.AddAsync(teacher);
      }

      await _context.SaveChangesAsync();
    }

    public Task<Teacher?> GetByIdAsync(int id)
    {
      return _context.teacher.FirstOrDefaultAsync(t => t.Id == id);
    }

    public async Task RemoveByIdAsync(int id)
    {
      var teacherToDelete = await GetByIdAsync(id);
      
      if(teacherToDelete != null) 
      {
        _context.Teacher.Remove(teacherToDelete);
        await _context.SaveChangesAsync();
      }
    }

    public async Task SaveChangesAsync()
    {
      await _context.SaveChangesAsync();
    }

    public bool Exist(int id)
    {
      return _context.Teacher.Any(t => t.Id == id);
    }
  }
}