using SchoolManagment.Enums;
using SchoolManagment.Models;
using SchoolManagment.Models.ViewModels;

namespace SchoolManagment.Infrastructure
{
  public static class CreateStudent
  {
    public static Student ToStudent(this CreateStudentViewModel viewModel)
    {
      var student = new Student(
        viewModel.FirstName,
        viewModel.LastName,
        viewModel.Birthdate,
      );

      student.Email = viewModel?.Email;

      return student;
    }
  }
}