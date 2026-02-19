using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_payloadbase
{
    public string uuid { get; set; } = null!;

    public DateTime? att_date { get; set; }

    public short? weekday { get; set; }

    public DateTime? check_in { get; set; }

    public DateTime? check_out { get; set; }

    public int? duration { get; set; }

    public int? duty_duration { get; set; }

    public double work_day { get; set; }

    public DateTime? clock_in { get; set; }

    public DateTime? clock_out { get; set; }

    public int? total_time { get; set; }

    public int? duty_worked { get; set; }

    public int? actual_worked { get; set; }

    public int? unscheduled { get; set; }

    public int? remaining { get; set; }

    public int? total_worked { get; set; }

    public int? late { get; set; }

    public int? early_leave { get; set; }

    public int? _short { get; set; }

    public int? absent { get; set; }

    public int? leave { get; set; }

    public string? exception { get; set; }

    public short day_off { get; set; }

    public string? break_time_id { get; set; }

    public int emp_id { get; set; }

    public string? overtime_id { get; set; }

    public int? timetable_id { get; set; }

    public virtual personnel_employee emp { get; set; } = null!;

    public virtual att_timeinterval? timetable { get; set; }
}
