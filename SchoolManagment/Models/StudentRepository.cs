namespace SchoolManagment.Models
{
  public static class StudentRepository
  {
    private static List<Student> _students = new List<Student>();

    public static IQueryable<Student> students => _students.AsQueryable<Student>();

    public static void Save(Student student)
    {
      if (_students.Exists(s => s.Id == student.Id))
      {
        var pos = _students.FindIndex(s => s.Id == student.Id);
        _students[pos] = student;
      }
      else
      {
        student.Id = students.Count() == 0 ? 1
          : students.Max(s => s.Id) + 1;
        _students.Add(student);
      }
    }

    public static void RemoveById(int id)
    {
      if (students.Any(s => s.Id == id))
        _students.RemoveAll(s => s.Id == id);
    }

    public static Student? GetStudentById(int id)
    {
      return students.FirstOrDefault(s => s.Id == id);
    }

    public static bool Exist(int id)
    {
      return students.Any(s => s.Id == id);
    }
  }
}