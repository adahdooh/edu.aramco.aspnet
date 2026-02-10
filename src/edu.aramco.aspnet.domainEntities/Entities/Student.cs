namespace edu.aramco.aspnet.domainEntities.Entities;

public class Student : User
{
    public DateTime GraduationDate { get; set; }
    public DateTime EntranceDate { get; set; }
    public string Major { get; set; }
    public string Level { get; set; }
    public string ApplicationStatus { get; set; }
    public string? Justification { get; set; }
}