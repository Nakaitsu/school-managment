using Microsoft.EntityFrameworkCore;

namespace SchoolManagment.Models
{
  public static class SeedData
  {
    public static void EnsurePopulated(IApplicationBuilder app)
    {
      SchoolDbContext context = app.ApplicationServices
        .CreateScope().ServiceProvider.GetRequiredService<SchoolDbContext>();

      if(context.Database.GetPendingMigrations().Any())
        context.Database.Migrate();

      if(!context.Students.Any())
      {
        context.Students.AddRange(
          new Student {
            FirstName = "Karl",
            LastName = "Branting",
            Email = "karl@email.com",
            Phone = "11123412345",
            Birthdate = DateTime.Parse("05-05-2010"),
            GradeLevel = Enums.GradeLevels.Second,
            EnrollmentDate = DateTime.Parse("21-04-2012")
          },
          new Student {
            FirstName = "Angie",
            LastName = "Northrop",
            Email = "angel@email.com",
            Phone = "15223412345",
            Birthdate = DateTime.Parse("01-08-2011"),
            GradeLevel = Enums.GradeLevels.Fifth,
            EnrollmentDate = DateTime.Parse("23-01-2013")
          },
          new Student {
            FirstName = "Pedro",
            LastName = "De La Hoya",
            Email = "elpedro@email.com",
            Phone = "15223483457",
            Birthdate = DateTime.Parse("23-12-2011"),
            GradeLevel = Enums.GradeLevels.Kindergarten,
            EnrollmentDate = DateTime.Parse("15-08-2013")
          },
          new Student {
            FirstName = "Tom",
            LastName = "Gurney",
            Email = "tom22@email.com",
            Birthdate = DateTime.Parse("17-03-2007"),
            GradeLevel = Enums.GradeLevels.Second,
            EnrollmentDate = DateTime.Parse("27-09-2010")
          },
          new Student {
            FirstName = "Jimmy",
            LastName = "Hopkins",
            Email = "jimmyhopkins_29@email.com",
            Birthdate = DateTime.Parse("01-02-2009"),
            GradeLevel = Enums.GradeLevels.Ninth,
            EnrollmentDate = DateTime.Parse("02-01-2010")
          },
          new Student {
            FirstName = "Eunice",
            LastName = "Pound",
            Email = "eunice@email.com",
            Birthdate = DateTime.Parse("14-05-2004"),
            GradeLevel = Enums.GradeLevels.Seventh,
            EnrollmentDate = DateTime.Parse("23-10-2009")
          },
          new Student {
            FirstName = "Peanut",
            LastName = "Romano",
            Email = "peanut2_3@email.com",
            Birthdate = DateTime.Parse("16-04-2012"),
            GradeLevel = Enums.GradeLevels.Eighth,
            EnrollmentDate = DateTime.Parse("13-03-2015")
          },
          new Student {
            FirstName = "Gloria",
            LastName = "Jackson",
            Email = "gloriaj733@email.com",
            Birthdate = DateTime.Parse("09-05-2010"),
            GradeLevel = Enums.GradeLevels.Fourth,
            EnrollmentDate = DateTime.Parse("10-04-2012")
          },
          new Student {
            FirstName = "Zoe",
            LastName = "Taylor",
            Email = "ztaylor8@email.com",
            Phone = "09426718931",
            Birthdate = DateTime.Parse("22-11-2009"),
            GradeLevel = Enums.GradeLevels.Tenth,
            EnrollmentDate = DateTime.Parse("20-07-2010")
          },
          new Student {
            FirstName = "Sheldon",
            LastName = "Thompson",
            Email = "shell@email.com",
            Birthdate = DateTime.Parse("26-09-2007"),
            GradeLevel = Enums.GradeLevels.PreKindergarten,
            EnrollmentDate = DateTime.Parse("18-01-2008")
          },
          new Student {
            FirstName = "Gord",
            LastName = "Vendome",
            Email = "gordven0291@email.com",
            Birthdate = DateTime.Parse("27-04-2011"),
            GradeLevel = Enums.GradeLevels.Third,
            EnrollmentDate = DateTime.Parse("26-07-2012")
          },
          new Student {
            FirstName = "Davis",
            LastName = "White",
            Email = "d2white@email.com",
            Birthdate = DateTime.Parse("20-05-2007"),
            GradeLevel = Enums.GradeLevels.Sixth,
            EnrollmentDate = DateTime.Parse("13-03-2010")
          },
          new Student {
            FirstName = "Mandy",
            LastName = "Wiles",
            Email = "mandyw9ile7@email.com",
            Birthdate = DateTime.Parse("06-06-2008"),
            GradeLevel = Enums.GradeLevels.Eleventh,
            EnrollmentDate = DateTime.Parse("12-05-2010")
          },
          new Student {
            FirstName = "Norton",
            LastName = "Williams",
            Email = "n7will@email.com",
            Birthdate = DateTime.Parse("12-11-2012"),
            GradeLevel = Enums.GradeLevels.Twelfth,
            EnrollmentDate = DateTime.Parse("10-02-2014")
          }
        );

        context.SaveChanges();
      }

      if(!context.Courses.Any())
      {
        context.Courses.AddRange(
          new Course { CourseID = 1022, Title = "Chemistry" },
          new Course { CourseID = 1075, Title = "Art" },
          new Course { CourseID = 4080, Title = "History" },
          new Course { CourseID = 3095, Title = "Biology" },
          new Course { CourseID = 1030, Title = "Photography" },
          new Course { CourseID = 2010, Title = "Shop" },
          new Course { CourseID = 4070, Title = "Math" },
          new Course { CourseID = 3021, Title = "Geography" },
          new Course { CourseID = 1047, Title = "English" },
          new Course { CourseID = 3011, Title = "Gym" },
          new Course { CourseID = 5009, Title = "Home Economics" },
          new Course { CourseID = 4037, Title = "Music" }
        );

        context.SaveChanges();
       }

      if(!context.Enrollments.Any())
      {
        context.Enrollments.AddRange(
          new Enrollment { StudentID = 1, CourseID = 4080, Grade = Grade.C },
          new Enrollment { StudentID = 1, CourseID = 1022, Grade = Grade.A },
          new Enrollment { StudentID = 2, CourseID = 4070, Grade = Grade.B },
          new Enrollment { StudentID = 3, CourseID = 5009, Grade = Grade.A },
          new Enrollment { StudentID = 4, CourseID = 1075, Grade = Grade.D },
          new Enrollment { StudentID = 4, CourseID = 3011, Grade = Grade.C },
          new Enrollment { StudentID = 5, CourseID = 1022, Grade = Grade.C },
          new Enrollment { StudentID = 6, CourseID = 1022, Grade = Grade.F },
          new Enrollment { StudentID = 7, CourseID = 2010, Grade = Grade.B },
          new Enrollment { StudentID = 8, CourseID = 1030, Grade = Grade.B },
          new Enrollment { StudentID = 9, CourseID = 3021, Grade = Grade.E },
          new Enrollment { StudentID = 10, CourseID = 3095, Grade = Grade.A },
          new Enrollment { StudentID = 10, CourseID = 4037, Grade = Grade.A },
          new Enrollment { StudentID = 11, CourseID = 1047, Grade = Grade.C },
          new Enrollment { StudentID = 12, CourseID = 1030, Grade = Grade.D },
          new Enrollment { StudentID = 13, CourseID = 5009, Grade = Grade.B },
          new Enrollment { StudentID = 14, CourseID = 4080, Grade = Grade.D }
        );

        context.SaveChanges();
      }

    }
  }
}