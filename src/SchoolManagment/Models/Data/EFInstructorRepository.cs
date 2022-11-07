using Microsoft.EntityFrameworkCore;

namespace SchoolManagment.Models
{
  public class EFInstructorRepository : ISchoolRepository<Instructor>
  {
    private readonly SchoolDbContext _context;

    public IQueryable<Instructor> Items => _context.Instructors.AsNoTracking();

    public EFInstructorRepository(SchoolDbContext ctx)
    {
      _context = ctx;
    }

    public async Task CreateAcademicRegister(int userId, int academicId) {
      await _context.InstructorsAcademicRegisters.AddAsync(new InstructorAcademicRegister(userId, academicId));
      await _context.SaveChangesAsync();
    }

    public async Task<InstructorAcademicRegister> GetAcademicRegister(int userId) {
      var SAR = await _context.InstructorsAcademicRegisters.FirstOrDefaultAsync(SAR => SAR.UserId == userId);

      if(SAR != null)
        return SAR;

      return default(InstructorAcademicRegister);
    }

    public async Task<int> SaveAsync(Instructor instructor)
    {
      if(_context.Instructors.Any(t => t.Id == instructor.Id))
      {
        var result = await _context.Instructors
          .AsNoTracking().FirstOrDefaultAsync(t => t.Id == instructor.Id);
          
        if(result != null)
          _context.Instructors.Update(instructor);
      }
      else
      {
        await _context.AddAsync(instructor);
      }

      await _context.SaveChangesAsync();

      return instructor.Id;
    }

    public Task<Instructor?> GetByIdAsync(int id)
    {
      return _context.Instructors.FirstOrDefaultAsync(t => t.Id == id);
    }

    public async Task RemoveByIdAsync(int id)
    {
      var instructorToDelete = await GetByIdAsync(id);
      
      if(instructorToDelete != null) 
      {
        _context.Instructors.Remove(instructorToDelete);
        await _context.SaveChangesAsync();
      }
    }

    public async Task SaveChangesAsync()
    {
      await _context.SaveChangesAsync();
    }

    public bool Exist(int id)
    {
      return _context.Instructors.Any(t => t.Id == id);
    }
  }
}