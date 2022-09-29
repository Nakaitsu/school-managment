namespace SchoolManagment.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public int RA { get; set; }
        public int[] Turmas { get; set; }
        public string Email { get; set; } // atribuir o email do user associado
    }
}