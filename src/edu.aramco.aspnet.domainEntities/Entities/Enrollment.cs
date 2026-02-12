namespace edu.aramco.aspnet.domainEntities.Entities;

public class Enrollment
{
    public DateTime EnrollmentDate { get; set; }
    public Guid StudentId { get; set; }
    public int CourseId { get; set; }
    public Student Student { get; set; }
    public Course Course { get; set; }
}
