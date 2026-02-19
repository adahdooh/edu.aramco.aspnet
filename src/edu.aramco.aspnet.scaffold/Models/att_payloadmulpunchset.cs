using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_payloadmulpunchset
{
    public int id { get; set; }

    public DateTime att_date { get; set; }

    public short? weekday { get; set; }

    public short data_index { get; set; }

    public DateTime? clock_in { get; set; }

    public int? in_id { get; set; }

    public DateTime? clock_out { get; set; }

    public int? out_id { get; set; }

    public int? total_time { get; set; }

    public int? worked_time { get; set; }

    public short data_type { get; set; }

    public int emp_id { get; set; }

    public int? timetable_id { get; set; }

    public virtual personnel_employee emp { get; set; } = null!;
}
