using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagment.Models
{
  public abstract class Client
  {
    [StringLength(50)]
    public string FirstName { get; set; }
    
    [StringLength(50)]
    public string LastName { get; set; }
        
    [DataType(DataType.Date)]
    [Column(TypeName = "Date")]
    public DateTime Birthdate { get; set; }

    public Client(string firstName, string lastName, DateTime birthdate)
    {
      FirstName = firstName;
      LastName = lastName;
      Birthdate = birthdate;
    }

    public Client()
    {

    }
  }
}