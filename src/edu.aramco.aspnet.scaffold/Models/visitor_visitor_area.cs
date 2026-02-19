using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class visitor_visitor_area
{
    public int id { get; set; }

    public int visitor_id { get; set; }

    public int area_id { get; set; }

    public virtual personnel_area area { get; set; } = null!;

    public virtual visitor_visitor visitor { get; set; } = null!;
}
