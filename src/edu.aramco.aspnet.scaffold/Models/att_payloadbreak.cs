using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_payloadbreak
{
    public string uuid { get; set; } = null!;

    public DateTime? break_out { get; set; }

    public DateTime? break_in { get; set; }

    public int? duration { get; set; }

    public int? taken { get; set; }

    public int? actual_duration { get; set; }

    public int? early_in { get; set; }

    public int? late_in { get; set; }

    public int? late { get; set; }

    public int? early_leave { get; set; }

    public int? absent { get; set; }

    public int? work_time { get; set; }

    public int? overtime { get; set; }

    public int? weekend_ot { get; set; }

    public int? holiday_ot { get; set; }
}
