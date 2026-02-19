namespace edu.aramco.aspnet.ui.Models
{
    public class StudentCard
    {
        public Guid Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public char Gender { get; set; }
        public string Password { get; set; }
        public DateTime GraduationDate { get; set; }
    }
}
