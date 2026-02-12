namespace edu.aramco.aspnet.api.Models.Requests
{
    public class CourseRequestModel
    {
        public string? Author { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
        public int Hours { get; set; }
        public Guid InstructorId { get; set; }
    }
}
