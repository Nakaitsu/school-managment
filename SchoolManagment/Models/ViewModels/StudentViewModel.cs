using System.ComponentModel.DataAnnotations;
using SchoolManagment.Enums;
using SchoolManagment.Infrastructure;

namespace SchoolManagment.Models
{
  public class StudentViewModel
  {
    public int Id { get; set; }
    
    [Required(ErrorMessage = "This field must be not empty")]
    [StringLength(50, ErrorMessage = "First name length can't be more than 8.")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "This field must be not empty")]
    [StringLength(50, ErrorMessage = "Last name length can't be more than 8.")]
    public string LastName { get; set; }

    [EmailAddress(ErrorMessage = "Enter a valid email")]
    [StringLength(70)]
    public string? Email { get; set; }

    [Phone(ErrorMessage = "Enter a valid phone number")]
    public string? Phone { get; set; }

    [Required(ErrorMessage = "You must specify the student's age")]
    [DataType(DataType.Date)]
    [ValidateDate]
    public DateTime Birthday { get; set; }

    [Required(ErrorMessage = "This field is required")]
    public Grades? Grade { get; set; }
  }
}