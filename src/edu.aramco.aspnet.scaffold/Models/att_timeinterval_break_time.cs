using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_timeinterval_break_time
{
    public int id { get; set; }

    public int timeinterval_id { get; set; }

    public int breaktime_id { get; set; }

    public virtual att_breaktime breaktime { get; set; } = null!;

    public virtual att_timeinterval timeinterval { get; set; } = null!;
}
