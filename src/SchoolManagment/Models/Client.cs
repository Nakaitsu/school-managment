using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagment.Models
{
  public abstract class Client : User
  {
    [StringLength(50)]
    public string FirstName { get; set; }
    
    [StringLength(50)]
    public string LastName { get; set; }
        
    [DataType(DataType.Date)]
    [Column(TypeName = "Date")]
    public DateTime Birthdate { get; set; }

    public Client(string firstName, string lastName, DateTime birthdate) : base(login: "", password: "")
    {
      FirstName = firstName;
      LastName = lastName;
      Birthdate = birthdate;
    }

    public Client() : base(login: "", password: "")
    {

    }
  }
}