using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class personnel_certification
{
    public int id { get; set; }

    public string cert_code { get; set; } = null!;

    public string cert_name { get; set; } = null!;

    public virtual ICollection<personnel_employeecertification> personnel_employeecertifications { get; set; } = new List<personnel_employeecertification>();

    public virtual ICollection<visitor_reservation> visitor_reservations { get; set; } = new List<visitor_reservation>();

    public virtual ICollection<visitor_visitor> visitor_visitors { get; set; } = new List<visitor_visitor>();
}
