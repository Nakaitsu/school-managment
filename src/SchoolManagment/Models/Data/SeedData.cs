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
            Birthdate = DateTime.Parse("05-05-2010"),
            EnrollmentDate = DateTime.Parse("21-04-2012")
          },
          new Student {
            FirstName = "Angie",
            LastName = "Northrop",
            Birthdate = DateTime.Parse("01-08-2011"),
            EnrollmentDate = DateTime.Parse("23-01-2013")
          },
          new Student {
            FirstName = "Pedro",
            LastName = "De La Hoya",
            Birthdate = DateTime.Parse("23-12-2011"),
            EnrollmentDate = DateTime.Parse("15-08-2013")
          },
          new Student {
            FirstName = "Tom",
            LastName = "Gurney",
            Birthdate = DateTime.Parse("17-03-2007"),
            EnrollmentDate = DateTime.Parse("27-09-2010")
          },
          new Student {
            FirstName = "Jimmy",
            LastName = "Hopkins",
            Birthdate = DateTime.Parse("01-02-2009"),
            EnrollmentDate = DateTime.Parse("02-01-2010")
          },
          new Student {
            FirstName = "Eunice",
            LastName = "Pound",
            Birthdate = DateTime.Parse("14-05-2004"),
            EnrollmentDate = DateTime.Parse("23-10-2009")
          },
          new Student {
            FirstName = "Peanut",
            LastName = "Romano",
            Birthdate = DateTime.Parse("16-04-2012"),
            EnrollmentDate = DateTime.Parse("13-03-2015")
          },
          new Student {
            FirstName = "Gloria",
            LastName = "Jackson",
            Birthdate = DateTime.Parse("09-05-2010"),
            EnrollmentDate = DateTime.Parse("10-04-2012")
          },
          new Student {
            FirstName = "Zoe",
            LastName = "Taylor",
            Birthdate = DateTime.Parse("22-11-2009"),
            EnrollmentDate = DateTime.Parse("20-07-2010")
          },
          new Student {
            FirstName = "Sheldon",
            LastName = "Thompson",
            Birthdate = DateTime.Parse("26-09-2007"),
            EnrollmentDate = DateTime.Parse("18-01-2008")
          },
          new Student {
            FirstName = "Gord",
            LastName = "Vendome",
            Birthdate = DateTime.Parse("27-04-2011"),
            EnrollmentDate = DateTime.Parse("26-07-2012")
          },
          new Student {
            FirstName = "Davis",
            LastName = "White",
            Birthdate = DateTime.Parse("20-05-2007"),
            EnrollmentDate = DateTime.Parse("13-03-2010")
          },
          new Student {
            FirstName = "Mandy",
            LastName = "Wiles",
            Birthdate = DateTime.Parse("06-06-2008"),
            EnrollmentDate = DateTime.Parse("12-05-2010")
          },
          new Student {
            FirstName = "Norton",
            LastName = "Williams",
            Birthdate = DateTime.Parse("12-11-2012"),
            EnrollmentDate = DateTime.Parse("10-02-2014")
          }
        );

        context.SaveChanges();
      }

      if(!context.Courses.Any())
      {
        context.Courses.AddRange(
          new Course { 
            CourseID = 1022,
            Title = "Chemistry",
            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptatibus, repellat nam odit, sapiente alias esse cupiditate, fugiat doloribus voluptates ullam numquam itaque perspiciatis inventore quas odio. Quis soluta libero impedit.",
            ImagePath = "~/img/courses/chemistry.jpg"},
          new Course { 
            CourseID = 1075,
            Title = "Art",
            Description = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Eum ab culpa suscipit pariatur officia. Inventore obcaecati alias aliquam a amet eum quod ea similique repellat? Repellendus praesentium voluptatum impedit assumenda.",
            ImagePath = "~/img/courses/art.jpg" },
          new Course { 
            CourseID = 4080,
            Title = "History",
            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Incidunt exercitationem eveniet accusamus magni eius corporis ipsa at neque ad minima impedit quia, eaque maxime expedita nulla odio quae quasi excepturi.",
            ImagePath = "~/img/courses/history.jpg" },
          new Course { 
            CourseID = 3095,
            Title = "Biology",
            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Ipsam laudantium ipsa, deleniti qui harum debitis accusamus sequi doloremque quibusdam voluptate? Velit error enim necessitatibus vero dolores laborum quam ut delectus.",
            ImagePath = "~/img/courses/biology.jpg"},
          new Course { 
            CourseID = 1030,
            Title = "Photography",
            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolore aliquid fuga id, soluta incidunt fugiat blanditiis quas enim accusamus illo tempore a quia, earum, maxime nemo tenetur? Consequatur, aliquam tempore.",
            ImagePath = "~/img/courses/photography.jpg" },
          new Course { 
            CourseID = 2010,
            Title = "Shop",
            Description = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Non obcaecati fugit optio corporis esse modi voluptates reiciendis maiores id autem, molestias rerum ipsam facilis cumque consequatur similique laudantium nobis sed.",
            ImagePath = "~/img/courses/shop.jpg" },
          new Course { 
            CourseID = 4070,
            Title = "Math",
            Description = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Repellendus, inventore temporibus! Minus reiciendis culpa, dignissimos excepturi ad ipsam molestiae, optio necessitatibus assumenda aspernatur distinctio expedita. Placeat soluta iure similique veniam.",
            ImagePath = "~/img/courses/math.jpg"},
          new Course { 
            CourseID = 3021,
            Title = "Geography",
            Description = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Est cum quasi quod molestias autem assumenda, cumque quae accusantium quia repudiandae temporibus, quam eos illo adipisci nesciunt earum natus. Totam, eaque.",
            ImagePath = "~/img/courses/geography.jpg" },
          new Course { 
            CourseID = 1047,
            Title = "English",
            Description = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Quasi, sapiente. Voluptatibus repellendus officia voluptates doloremque voluptatem maxime beatae pariatur minima suscipit rem consequatur, voluptatum et. Rerum itaque corporis harum exercitationem!",
            ImagePath = "~/img/courses/english.jpg"},
          new Course { 
            CourseID = 3011,
            Title = "Gym",
            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Omnis fugiat sed soluta perspiciatis consectetur sapiente sunt animi, labore amet corporis eaque aperiam vel modi. Quo aliquid corrupti quam doloremque ullamk.",
            ImagePath = "~/img/courses/gym.jpg" },
          new Course { 
            CourseID = 5009,
            Title = "Home Economics",
            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Accusantium sit qui voluptates magni blanditiis amet pariatur quibusdam illum quisquam tempore sed error quis voluptatem necessitatibus praesentium, officia, nostrum dicta consequatur.",
            ImagePath = "~/img/courses/home-economics.jpg"},
          new Course { 
            CourseID = 4037,
            Title = "Music",
            Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sint beatae ratione ad dicta atque laudantium voluptas velit quo minima adipisci aspernatur provident perferendis quas ab placeat, mollitia voluptate officia nemo!",
            ImagePath = "~/img/courses/music.jpg" }
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