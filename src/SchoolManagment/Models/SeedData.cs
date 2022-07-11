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
            GradeLevels = Enums.GradeLevels.Second
          },
          new Student {
            FirstName = "Angie",
            LastName = "Northrop",
            Email = "angel@email.com",
            Phone = "15223412345",
            Birthdate = DateTime.Parse("01-08-2011"),
            GradeLevels = Enums.GradeLevels.Fifth
          },
          new Student {
            FirstName = "Pedro",
            LastName = "De La Hoya",
            Email = "elpedro@email.com",
            Phone = "15223483457",
            Birthdate = DateTime.Parse("23-12-2011"),
            GradeLevels = Enums.GradeLevels.Kindergarden
          },
          new Student {
            FirstName = "Tom",
            LastName = "Gurney",
            Email = "tom22@email.com",
            Birthdate = DateTime.Parse("17-03-2007"),
            GradeLevels = Enums.GradeLevels.Second
          },
          new Student {
            FirstName = "Jimmy",
            LastName = "Hopkins",
            Email = "jimmyhopkins_29@email.com",
            Birthdate = DateTime.Parse("01-02-2009"),
            GradeLevels = Enums.GradeLevels.Ninth
          },
          new Student {
            FirstName = "Eunice",
            LastName = "Pound",
            Email = "eunice@email.com",
            Birthdate = DateTime.Parse("14-05-2004"),
            GradeLevels = Enums.GradeLevels.Seventh
          },
          new Student {
            FirstName = "Peanut",
            LastName = "Romano",
            Email = "peanut2_3@email.com",
            Birthdate = DateTime.Parse("16-04-2012"),
            GradeLevels = Enums.GradeLevels.Eighth
          },
          new Student {
            FirstName = "Gloria",
            LastName = "Jackson",
            Email = "gloriaj733@email.com",
            Birthdate = DateTime.Parse("09-05-2010"),
            GradeLevels = Enums.GradeLevels.Fourth
          },
          new Student {
            FirstName = "Zoe",
            LastName = "Taylor",
            Email = "ztaylor8@email.com",
            Phone = "09426718931",
            Birthdate = DateTime.Parse("22-11-2009"),
            GradeLevels = Enums.GradeLevels.Tenth
          },
          new Student {
            FirstName = "Sheldon",
            LastName = "Thompson",
            Email = "shell@email.com",
            Birthdate = DateTime.Parse("26-09-2007"),
            GradeLevels = Enums.GradeLevels.PreKindergarden
          },
          new Student {
            FirstName = "Gord",
            LastName = "Vendome",
            Email = "gordven0291@email.com",
            Birthdate = DateTime.Parse("27-04-2011"),
            GradeLevels = Enums.GradeLevels.Third
          },
          new Student {
            FirstName = "Davis",
            LastName = "White",
            Email = "d2white@email.com",
            Birthdate = DateTime.Parse("20-05-2007"),
            GradeLevels = Enums.GradeLevels.Sixth
          },
          new Student {
            FirstName = "Mandy",
            LastName = "Wiles",
            Email = "mandyw9ile7@email.com",
            Birthdate = DateTime.Parse("06-06-2008"),
            GradeLevels = Enums.GradeLevels.Eleventh
          },
          new Student {
            FirstName = "Norton",
            LastName = "Williams",
            Email = "n7will@email.com",
            Birthdate = DateTime.Parse("12-11-2012"),
            GradeLevels = Enums.GradeLevels.Twelfth
          }
        );

        context.SaveChanges();
      }

    }
  }
}