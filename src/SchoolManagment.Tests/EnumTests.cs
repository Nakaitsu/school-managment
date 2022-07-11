using SchoolManagment.Enums;
using SchoolManagment.Infrastructure;
using SchoolManagment.Models;

namespace SchoolManagment.Tests
{
  public class EnumTests
  {
    [Fact]
    public void CanGetDescription()
    {
      // Given
      GradeLevels grade = GradeLevels.First;

      // When
      var result = grade.GetDescription();
    
      // Then
      Assert.Equal(result, "1st");
      Assert.Equal(typeof(String), result.GetType());
    }

    [Fact]
    public void CanGetDescriptionFromStudentGrade()
    {
      // Given
      Student student = new Student (
        "Abbey",
        "Jackson",
        DateTime.Parse("05-08-2012"),
        GradeLevels.Second);

      // When
      var result = student.GradeLevels.GetDescription();
    
      // Then
      Assert.Equal(typeof(String), result.GetType());
      Assert.Equal(result, "2nd");
    }
  }
}