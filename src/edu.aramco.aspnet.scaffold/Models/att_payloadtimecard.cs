using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_payloadtimecard
{
    public string id { get; set; } = null!;

    public DateTime att_date { get; set; }

    public int week { get; set; }

    public int weekday { get; set; }

    public short date_type { get; set; }

    public string time_table_alias { get; set; } = null!;

    public DateTime check_in { get; set; }

    public DateTime check_out { get; set; }

    public decimal work_day { get; set; }

    public DateTime? clock_in { get; set; }

    public DateTime? clock_out { get; set; }

    public DateTime? break_out { get; set; }

    public DateTime? break_in { get; set; }

    public bool lock_down { get; set; }

    public short present { get; set; }

    public int emp_id { get; set; }

    public int? time_table_id { get; set; }

    public short full_attendance { get; set; }

    public int? in_trans_id { get; set; }

    public int? out_trans_id { get; set; }

    public string? payload { get; set; }

    public virtual personnel_employee emp { get; set; } = null!;

    public virtual iclock_transaction? in_trans { get; set; }

    public virtual iclock_transaction? out_trans { get; set; }

    public virtual att_timeinterval? time_table { get; set; }
}
