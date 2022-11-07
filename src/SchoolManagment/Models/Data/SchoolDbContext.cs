using Microsoft.EntityFrameworkCore;

namespace SchoolManagment.Models
{
  public class SchoolDbContext : DbContext
  {
    public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
    {
      
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Classroom> Classrooms { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<StudentAcademicRegister> StudentsAcademicRegisters { get; set; }
    public DbSet<InstructorAcademicRegister> InstructorsAcademicRegisters { get; set; }
  }
}