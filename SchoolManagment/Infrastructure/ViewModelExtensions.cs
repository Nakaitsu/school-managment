using SchoolManagment.Enums;
using SchoolManagment.Models;

namespace SchoolManagment.Infrastructure
{
  public static class CreateStudent
  {
    public static Student ToStudent(this StudentViewModel viewModel)
    {
      var student = new Student(
        viewModel.FirstName,
        viewModel.LastName,
        viewModel.Birthday,
        (Grades)viewModel.Grade!
      );

      student.Email = viewModel?.Email;
      student.Phone = viewModel?.Phone;

      return student;
    }
  }
}