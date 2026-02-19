using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class meeting_meetingpayloadbase
{
    public string id { get; set; } = null!;

    public DateTime start_time { get; set; }

    public DateTime end_time { get; set; }

    public int duration { get; set; }

    public DateTime meeting_date { get; set; }

    public DateTime? clock_in { get; set; }

    public DateTime? clock_out { get; set; }

    public int attended_duration { get; set; }

    public int late_in { get; set; }

    public int early_out { get; set; }

    public int absent { get; set; }

    public int emp_id { get; set; }

    public int meeting_id { get; set; }

    public virtual personnel_employee emp { get; set; } = null!;

    public virtual meeting_meetingentity meeting { get; set; } = null!;
}
