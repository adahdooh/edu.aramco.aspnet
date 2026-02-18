using System;
using System.Collections.Generic;
using System.Text;

namespace edu.aramco.aspnet.domainEntities.Entities
{
    public class SMS
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Body { get; set; }
        public bool IsProcessed { get; set; }
    }
}