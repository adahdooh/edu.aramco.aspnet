using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_shiftdetail
{
    public int id { get; set; }

    public DateTime in_time { get; set; }

    public DateTime out_time { get; set; }

    public int day_index { get; set; }

    public int shift_id { get; set; }

    public int time_interval_id { get; set; }

    public virtual att_attshift shift { get; set; } = null!;

    public virtual att_timeinterval time_interval { get; set; } = null!;
}
