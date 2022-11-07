using Microsoft.EntityFrameworkCore;

namespace SchoolManagment.Models
{
  public class EFStudentRepository : ISchoolRepository<Student>
  {
    private readonly SchoolDbContext _context;

    public IQueryable<Student> Items => _context.Students.AsNoTracking();

    public EFStudentRepository(SchoolDbContext ctx)
    {
      _context = ctx;
    }

    public async Task CreateAcademicRegister(int userId, int academicId) {
      await _context.StudentsAcademicRegisters.AddAsync(new StudentAcademicRegister(userId, academicId));
      await _context.SaveChangesAsync();
    }

    public async Task<StudentAcademicRegister> GetAcademicRegister(int userId) {
      var SAR = await _context.StudentsAcademicRegisters.FirstOrDefaultAsync(SAR => SAR.UserId == userId);

      if(SAR != null)
        return SAR;

      return default(StudentAcademicRegister);
    }

    public async Task<int> SaveAsync(Student student)
    {
      if (_context.Students.Any(s => s.Id == student.Id))
      {
        var result = await _context.Students
          .AsNoTracking().FirstOrDefaultAsync(s => s.Id == student.Id);

        if (result != null)
          _context.Students.Update(student);
      }
      else
      {
        student.EnrollmentDate = DateTime.Now;
        await _context.AddAsync(student);
      }

      await _context.SaveChangesAsync();

      return student.Id;
    }

    public Task<Student?> GetByIdAsync(int id)
    {
      return _context.Students.FirstOrDefaultAsync(s => s.Id == id);
    }

    public async Task RemoveByIdAsync(int id)
    {
      var studentToDelete = await GetByIdAsync(id);

      if (studentToDelete != null)
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