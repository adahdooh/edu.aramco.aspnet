using System;
using System.Collections.Generic;
using System.Text;

namespace edu.aramco.aspnet.domainEntities.Entities
{
    public class Major
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
