namespace SchoolManagment.Models 
{
    public class Turma 
    {
        public int Id { get; set; }
        public int Teacher_Id { get; set; }
        public int[] Students_Id { get; set; } 
        public int Course_Id { get; set; }
    }
}
