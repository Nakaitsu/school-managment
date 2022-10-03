namespace SchoolManagment.Models 
{
    public class Turma 
    {
        public int Id { get; set; }
        public int Teacher_Id { get; set; }
        public int Course_Id { get; set; }
        public ICollection<Student> Students { get; set; } 

        public Teacher Teacher { get; set;}
        public Course Course { get; set; }
    }
}
