using System.ComponentModel.DataAnnotations;

namespace SchoolManagment.Enums
{
  public enum Grades
  {
    [Display(Name = "Pre-Kindergarden")]
    PreKindergarden = 1,

    [Display(Name = "Kindergarden")]
    Kindergarden = 2,

    [Display(Name = "1st Grade")]
    First = 3,

    [Display(Name = "2nd Grade")]
    Second = 4,

    [Display(Name = "3rd Grade")]
    Third = 5,

    [Display(Name = "4th Grade")]
    Fourth = 6,

    [Display(Name = "5th Grade")]
    Fifth = 7,

    [Display(Name = "6th Grade")]
    Sixth = 8,

    [Display(Name = "7th Grade")]
    Seventh = 9,

    [Display(Name = "8th Grade")]
    Eighth = 10,

    [Display(Name = "9th Grade")]
    Ninth = 11,

    [Display(Name = "10th Grade")]
    Tenth = 12,

    [Display(Name = "11th Grade")]
    Eleventh = 13,

    [Display(Name = "12th Grade")]
    Twelfth = 13
  }
}