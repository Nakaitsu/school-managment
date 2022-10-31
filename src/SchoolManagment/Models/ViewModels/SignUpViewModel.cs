using System.ComponentModel.DataAnnotations;

namespace SchoolManagment.Models.ViewModels
{
  public class SignUpViewModel
  {
    [Required]
    [StringLength(50)]
    public string Login { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Compare(nameof(Password))]
    public string PasswordConfirm { get; set; }

    [Required]
    [StringLength(70)]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [Required]
    public UserRole Role { get; set; }
  }
}