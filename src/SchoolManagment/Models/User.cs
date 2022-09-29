namespace SchoolManagment.Models
{
    public class User 
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public UserType UserType { get; set; }
    }
}

enum UserType
{
    Client, Admin
}