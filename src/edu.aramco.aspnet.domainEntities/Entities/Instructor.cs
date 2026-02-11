namespace edu.aramco.aspnet.domainEntities.Entities;

public class Instructor : User
{
    public DateTime? ResignationDate { get; set; }
    public DateTime HireDate { get; set; }
    public string Department { get; set; }
    public string Qualifications { get; set; }

    // Relations
    public ICollection<Course> Courses { get; set; } = [];
}
