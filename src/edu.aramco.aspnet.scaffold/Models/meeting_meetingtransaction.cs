using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class meeting_meetingtransaction
{
    public int id { get; set; }

    public string emp_code { get; set; } = null!;

    public DateTime punch_datetime { get; set; }

    public DateTime punch_date { get; set; }

    public DateTime punch_time { get; set; }

    public string punch_state { get; set; } = null!;

    public short source { get; set; }

    public DateTime upload_time { get; set; }

    public int? emp_id { get; set; }

    public int? meeting_id { get; set; }

    public int? terminal_id { get; set; }

    public virtual personnel_employee? emp { get; set; }

    public virtual meeting_meetingentity? meeting { get; set; }

    public virtual iclock_terminal? terminal { get; set; }
}
