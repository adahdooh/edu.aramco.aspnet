using System;
using System.Collections.Generic;
using System.Text;

namespace edu.aramco.aspnet.domainEntities.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Author { get; set; }
        public int Hours { get; set; }
        public Guid InstructorId { get; set; }
        public Guid UpdatedByUserId { get; set; }
        public DateTime CreatedAt { get; set; }
        //public DateTime UpdatedAt { get; set; }

        // Navigation properties
        public Instructor Instructor { get; set; }
        //public User UpdatedBy{ get; set; }
    }
}