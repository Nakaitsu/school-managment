using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagment.Enums
{
  public enum GradeLevels
  {
    [Display(Name = "Pre-Kindergarten")]
    [Description("Pre-Kindergarten")]
    PreKindergarten = 1,

    [Display(Name = "Kindergarten")]
    [Description("Kindergarten")]
    Kindergarten = 2,

    [Display(Name = "1st Grade")]
    [Description("1st")]
    First = 3,

    [Display(Name = "2nd Grade")]
    [Description("2nd")]
    Second = 4,

    [Display(Name = "3rd Grade")]
    [Description("3rd")]
    Third = 5,

    [Display(Name = "4th Grade")]
    [Description("4th")]
    Fourth = 6,

    [Display(Name = "5th Grade")]
    [Description("5th")]
    Fifth = 7,

    [Display(Name = "6th Grade")]
    [Description("6th")]
    Sixth = 8,

    [Display(Name = "7th Grade")]
    [Description("7th")]
    Seventh = 9,

    [Display(Name = "8th Grade")]
    [Description("8th")]
    Eighth = 10,

    [Display(Name = "9th Grade")]
    [Description("9th")]

    Ninth = 11,

    [Display(Name = "10th Grade")]
    [Description("10th")]
    Tenth = 12,

    [Display(Name = "11th Grade")]
    [Description("11th")]
    Eleventh = 13,

    [Display(Name = "12th Grade")]
    [Description("12th")]
    Twelfth = 14
  }
}