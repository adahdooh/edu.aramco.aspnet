using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class visitor_visitorlog
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public short? visitor_status { get; set; }

    public int visitor_id { get; set; }

    public virtual visitor_visitor visitor { get; set; } = null!;
}
