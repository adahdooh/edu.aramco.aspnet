using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class visitor_reason
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public string? visit_reason { get; set; }

    public virtual ICollection<visitor_reservation> visitor_reservations { get; set; } = new List<visitor_reservation>();

    public virtual ICollection<visitor_visitor> visitor_visitors { get; set; } = new List<visitor_visitor>();
}
