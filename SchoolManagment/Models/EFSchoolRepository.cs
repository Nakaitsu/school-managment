namespace SchoolManagment.Models
{
  public class EFSchoolRepository : ISchoolRepository
  {
    private SchoolDbContext _context;
    
    public EFSchoolRepository(SchoolDbContext ctx)
    {
      _context = ctx;
    }
    
    public IQueryable<Student> Students => _context.Students;
  }
}